using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class SubscriptionPackage
    {
        public SubscriptionPackage()
        {
            Customers = new List<Customer>();
        }
        public int SubscriptionPackageId { get; set; }
        public decimal BasePrice { get; set; }
        public float DiscountPercent { get; set; }

        public IList<Customer> Customers { get; set; } 
    }
}
