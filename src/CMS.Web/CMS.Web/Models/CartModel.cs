using CMS.Core.Entites;
using CMS.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Web.Models
{
    public class CartModel
    {
        public IEnumerable<Event> Events { get; set; }
    }
}
