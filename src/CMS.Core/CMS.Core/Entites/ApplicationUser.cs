using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace CMS.Core.Entites
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Role { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
