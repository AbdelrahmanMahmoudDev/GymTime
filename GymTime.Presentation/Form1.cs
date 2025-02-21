
using GymTime.DataAccess;

namespace GymTime.Presentation
{
    public partial class Form1 : BaseForm
    {
        GymTimeContext context = new GymTimeContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var reg = new RegisterScreen();
            reg.FormClosing += delegate { this.Show(); };
            reg.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(rb_Customer.Checked)
            {
                var user = context.CustomerPasswords.Where(s => s.CustomerUsername == tb_Username.Text)
                                                    .ToList();
                //TODO Duplicates ??
                if(user.Count == 1)
                {
                    if(PasswordHasher.VerifyPassword(tb_Password.Text, user[0].PasswordHash, user[0].PasswordSalt))
                    {
                        // go to screen
                        var reg = new CustomerDash(context.Customers.Where(c => c.CustomerId == user[0].CustomerId)
                                                                    .Select(c => c.FirstName).FirstOrDefault());
                        reg.FormClosing += delegate { this.Show(); };
                        reg.Show();
                        this.Hide();
                    }
                }
            }
            else if(rb_Manager.Checked)
            {
                var user = context.ManagerPasswords.Where(s => s.ManagerUsername == tb_Username.Text)
                                    .ToList();
                //TODO Duplicates ??
                if (user.Count == 1)
                {
                    if (PasswordHasher.VerifyPassword(tb_Password.Text, user[0].PasswordHash, user[0].PasswordSalt))
                    {
                        // go to screen
                    }
                }
            }
            else
            {
                var user = context.TrainerPasswords.Where(s => s.TrainerUsername == tb_Username.Text)
                                    .ToList();
                //TODO Duplicates ??
                if (user.Count == 1)
                {
                    if (PasswordHasher.VerifyPassword(tb_Password.Text, user[0].PasswordHash, user[0].PasswordSalt))
                    {
                        // go to screen
                    }
                }
            }
        }
    }
}
