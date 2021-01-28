using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Infrastructure.MsSQL;
using CMS.Web.Models;
using CMS.Web.Requests;
using CMS.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace CMS.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IEventService _service;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationContext _context;

        public CartController(IEventService service, IHttpContextAccessor httpContextAccessor, ApplicationContext context)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        [HttpPost("/Cart/checkout")]
        public async Task<IActionResult> Submit(CheckoutModel model)
        {
            if (model == null)
            {
                return Redirect("/Cart/Cart");
            }

            if (model.Cart == null || model.Cart.Count == 0)
            {
                return Redirect("/Cart/Cart");
            }

            foreach (var eve in model.Cart)
            {
                var eventId = eve.Key;
                var count = eve.Value;

                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

                var purchase = new Purchase() { UserId = int.Parse(userId) };
                _context.Add(purchase);

                var eveDb = await _context.Set<Event>().FirstOrDefaultAsync(x => x.ID == eventId);
                if (eveDb == null)
                {
                    return BadRequest();
                }

                for (int i = 0; i < count; i++)
                {
                    var ticket = new Ticket();
                    ticket.Event = eveDb;
                    ticket.Purchase = purchase;
                    ticket.PricePLN = eveDb.TicketPrice;
                    _context.Add(ticket);
                }
                _context.SaveChanges();


                return Redirect("/MyEvents");
            }

            return View();
        }

        [HttpGet("/Cart/cart")]
        public async Task<IActionResult> Cart()
        {
            return View(new CartModel() { Events = _service.GetEvents().Result });
        }
    }
}
