using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace GymTime.DataAccess
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int? TrainerId { get; set; }
        public Trainer? Trainer { get; set; }
        public int? SubscriptionPackageId { get; set; }
        public SubscriptionPackage? SubPack { get; set; }
        public int? TrainingScheduleId { get; set; }
        public TrainingSchedule Schedule { get; set; }
        public int? CustomerPasswordId { get; set; }
        public CustomerPassword CustomerPassword { get; set; }
    }
}
