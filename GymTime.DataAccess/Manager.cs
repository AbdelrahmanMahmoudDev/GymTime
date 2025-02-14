using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<Trainer> Trainers { get; set; } = new List<Trainer>();
        public ManagerPassword ManagerPassword { get; set; }
    }
}
