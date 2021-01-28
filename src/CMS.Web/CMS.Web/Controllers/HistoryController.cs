using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using Microsoft.Extensions.Logging;

namespace CMS.Web.Controllers
{
    [Authorize]


    public class HistoryController : Controller
    {

        private readonly IPurchaseService _service;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationContext _context;

        public HistoryController(IPurchaseService service, IHttpContextAccessor httpContextAccessor, ApplicationContext context)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        [HttpGet("/MyEvents")]
        public async Task<IActionResult> MyEvents()
        {
            var purchases = await _service.GetPurchases();

            List<PurchaseModel> result = new List<PurchaseModel>();


            foreach (var purchase in purchases)
            {
                PurchaseModel purchaseModel = new PurchaseModel()
                {
                    Tickets = new List<TicketModel>(),
                    PurchaseId = purchase.ID
                };

                foreach (var ticket in purchase.Tickets)
                {


                    var t = new TicketModel()
                    {
                        EventId = ticket.EventId,
                        PricePLN = ticket.PricePLN,
                        TicketId = ticket.ID,
                        Event = new EventModel()
                        {
                            EventId = ticket.Event.ID,
                            City = ticket.Event.City,
                            Date = ticket.Event.Date,
                            DescriptionEn = ticket.Event.DescriptionEn,
                            DescriptionPl = ticket.Event.DescriptionPl,
                            EventType = ticket.Event.EventType,
                            Latitude = ticket.Event.Latitude,
                            Longitude = ticket.Event.Longitude,
                            NameEn = ticket.Event.NameEn,
                            NamePl = ticket.Event.NamePl,
                            Organisator = ticket.Event.Organisator,
                            PhotoPath = ticket.Event.PhotoPath,
                            TicketPrice = ticket.Event.TicketPrice
                        }
                    };
                    purchaseModel.Tickets.Add(t);
                }

                result.Add(purchaseModel);
            }

            return View(result);
        }
    }
}
