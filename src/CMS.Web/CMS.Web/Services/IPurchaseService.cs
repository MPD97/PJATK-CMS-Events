using System.Collections.Generic;
using System.Threading.Tasks;
using CMS.Core.Entites;

namespace CMS.Web.Services
{
    public interface IPurchaseService
    {
        public Task<IEnumerable<Purchase>> GetPurchases();
    }
}