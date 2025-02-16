using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public decimal KPI { get; set; }
        public IList<Customer> Customers { get; set; } = new List<Customer>();
        public IList<TrainingSchedule> Schedules { get; set; } = new List<TrainingSchedule>();
        public int? ManagerId { get; set; }
        public Manager Manager { get; set; }
        public TrainerPassword TrainerPassword { get; set; }
    }
}
