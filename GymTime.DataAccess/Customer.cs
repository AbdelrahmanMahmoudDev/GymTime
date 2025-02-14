using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public Trainer Trainer { get; set; }
        public SubscriptionPackage SubPack { get; set; }
        public TrainingSchedule Schedule { get; set; }
        public CustomerPassword CustomerPassword { get; set; }
    }
}
