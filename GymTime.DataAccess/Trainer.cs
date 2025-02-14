using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class Trainer
    {
        public Trainer()
        {
            Customers = new List<Customer>();
            Schedules = new List<TrainingSchedule>();
        }
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public decimal KPI { get; set; }
        public IList<Customer> Customers { get; set; }
        public IList<TrainingSchedule> Schedules { get; set; }
        public Manager Manager { get; set; }
    }
}
