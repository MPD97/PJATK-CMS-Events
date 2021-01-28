using System.Collections.Generic;
using System.Threading.Tasks;
using CMS.Core.Entites;

namespace CMS.Web.Services
{
    public interface ICommentService
    {
        public Task<IEnumerable<Comment>> GetComments(int eventId);

        public Task AddAsync(Comment comment);

        public Task<int> SaveChangesAsync();
    }
}