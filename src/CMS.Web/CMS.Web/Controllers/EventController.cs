using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Web.Controllers
{
    public class EventController : Controller
    {
        
        [HttpGet("{id}")]
        public IActionResult Event(int id)
        {
            return View();
        }
    }
}
