using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.DataAccess
{
    public class TrainerPassword
    {
        [Key, ForeignKey("Trainer")]
        public int TrainerPasswordId { get; set; }
        public string TrainerUsername { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Trainer Trainer { get; set; }
    }
}
