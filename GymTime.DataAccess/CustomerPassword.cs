using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class CustomerPassword
    {
        [Key, ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public string CustomerUsername { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public Customer Customer { get; set; }
    }
}
