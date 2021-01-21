using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Infrastructure.MsSQL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CMS.Web.Areas.Identity.Pages.Cart
{
    public class CartModel : PageModel
    {
        private readonly ApplicationContext _context;

        public CartModel(ApplicationContext context)
        {
            _context = context;
        }

        /* public IEnumerable<Purchase> Purchases { get; set; }

         public async Task OnGet()
         {
             Purchases = await _context.Set<Purchase>()
                 .Include(purchase => purchase.Tickets)
                 .ThenInclude(ticket => ticket.Event)
                 .Include(purchase => purchase.Tickets)
                 .ThenInclude(ticket => ticket.Person)
                 .Include(purchase => purchase.User)
                 .ToListAsync();
         }*/
        public IEnumerable<Event> Events { get; set; }





    }
}
