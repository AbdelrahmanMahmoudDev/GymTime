using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymTime.Presentation
{
    public partial class RegisterScreen : BaseForm
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void btn_PreManager_Click(object sender, EventArgs e)
        {

        }

        private void btn_PreTrainer_Click(object sender, EventArgs e)
        {

        }

        private void btn_PreCustomer_Click(object sender, EventArgs e)
        {
            var reg = new CustomerRegistration();
            reg.FormClosing += delegate { this.Show(); };
            reg.Show();
            this.Hide();
        }
    }
}
