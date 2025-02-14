using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class TrainingSchedule
    {
        public int TrainingScheduleId { get; set; }
        public DateTime FirstDay { get; set; } 
        public DateTime SecondDay { get; set; } 
        public DateTime ThirdDay { get; set; }
        public DateTime FourthDay { get; set; }

        public Trainer Trainer { get; set; }
        public int TrainerId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
