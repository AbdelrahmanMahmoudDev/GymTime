using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class ManagerPassword
    {
        [Key, ForeignKey("Manager")]
        public int ManagerPasswordId { get; set; }
        public string ManagerUsername { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Manager Manager { get; set; }
    }
}
