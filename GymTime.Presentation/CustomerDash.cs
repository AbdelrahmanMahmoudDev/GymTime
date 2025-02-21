using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymTime.DataAccess;

namespace GymTime.Presentation
{
    public partial class CustomerDash : BaseForm
    {
        private GymTimeContext DbContext = new GymTimeContext();
        public CustomerDash(string name)
        {
            InitializeComponent();
            gymLabel1.Text += $" {name}";
            // load subscription package
            var AssocPackages = DbContext.Customers.Select(c => c.SubPack)
                                                   .FirstOrDefault();
            if(AssocPackages != null)
            {
                                
            }
            // load trainer

            // load schedule
        }
    }
}
