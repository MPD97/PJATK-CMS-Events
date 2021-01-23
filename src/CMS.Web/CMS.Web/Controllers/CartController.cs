using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Entites;
using CMS.Web.Models;
using CMS.Web.Requests;
using CMS.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace CMS.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IEventService _service;

        public CartController(IEventService service)
        {
            _service = service;
        }

        [HttpGet("/Cart/checkout")]
        public async Task<IActionResult> Submit()
        {
            return View();
        }

        [HttpGet("/Cart/cart")]
        public async Task<IActionResult> Cart()
        {
            return View(new CartModel() { Events = _service.GetEvents().Result });
        }
    }
}
