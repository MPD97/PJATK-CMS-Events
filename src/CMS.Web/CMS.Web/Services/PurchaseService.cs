using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Infrastructure.MsSQL;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace CMS.Web.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly ApplicationContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PurchaseService(ApplicationContext context, IHttpContextAccessor httpContextAccessor) 
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public PurchaseService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Purchase>> GetPurchases()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var allPurchases = await _context.Set<Purchase>()
                .Where(x => x.UserId == int.Parse(userId))
                .Include(x => x.User)
                .Include(x => x.Tickets)
                .ThenInclude(x => x.Event)
                .ToListAsync();

            return allPurchases;
        }
    }
}