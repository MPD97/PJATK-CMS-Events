using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using CMS.Core.Entites;
using CMS.Infrastructure.MsSQL;
using Microsoft.EntityFrameworkCore;

namespace CMS.Web.Services
{
   
    public class CommentService : ICommentService
    {
        private readonly ApplicationContext _context;

        public CommentService(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task AddAsync(Comment comment)
        {
            await _context.Set<Comment>().AddAsync(comment);
        }

        public async Task<IEnumerable<Comment>> GetComments(int eventId)
        {
            var allComments = await _context.Set<Comment>()
                .Where(x => x.EventId == eventId)
                .ToListAsync();

            return allComments;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}