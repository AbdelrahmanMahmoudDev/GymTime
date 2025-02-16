using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymTime.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GymTime.Presentation
{
    public partial class CustomerRegistration : BaseForm
    {
        GymTimeContext context = new GymTimeContext();
        public CustomerRegistration()
        {
            InitializeComponent();
            var Trainers = context.Trainers.Select(trainer => new { TrainerId = trainer.TrainerId, FullName = $"{trainer.FirstName} {trainer.LastName}" })
                                           .ToList();
            cb_AssocTrainer.DataSource = Trainers;
            cb_AssocTrainer.ValueMember = "TrainerId";
            cb_AssocTrainer.DisplayMember = "FullName";

            var SubPackages = context.SubscriptionPackages.Select(package => new { PackId = package.SubscriptionPackageId, BasePrice = package.BasePrice })
                                                          .ToList();
            cb_AssocSubPack.DataSource = SubPackages;
            cb_AssocSubPack.ValueMember = "PackId";
            cb_AssocSubPack.DisplayMember = "BasePrice";

        }

        private async void btn_CustReg_Click(object sender, EventArgs e)
        {
            // prep data
            Customer NewCustData = new Customer()
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                TrainerId = (int?)(chb_TrainerChoice.Checked == true ? null : cb_AssocTrainer.SelectedValue),
                SubscriptionPackageId = (int?)(chb_SubChoice.Checked == true ? null : cb_AssocSubPack.SelectedValue)
            };
            (string hash, string salt) = PasswordHasher.HashPassword(tb_Password.Text);
            CustomerPassword NewCustPass = new CustomerPassword()
            {
                CustomerUsername = tb_Username.Text,
                PasswordHash = hash,
                PasswordSalt = salt
            };

            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                context.Customers.Add(NewCustData);
                await context.SaveChangesAsync();

                var items = await context.Customers
                                         .Select(c => c.CustomerId)
                                         .ToListAsync();

                NewCustPass.CustomerId = items
                                        .OrderDescending()
                                        .FirstOrDefault();

                context.CustomerPasswords.Add(NewCustPass);
                await context.SaveChangesAsync();
                await transaction.CommitAsync();

                MessageBox.Show("User Created!");
                Program.StartingScreen.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                Debug.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                MessageBox.Show(ex.ToString());
            }
        }

        private void chb_SubChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_SubChoice.Checked)
            {
                cb_AssocSubPack.Enabled = false;
            }
            else
            {
                cb_AssocSubPack.Enabled = true;
            }
        }

        private void chb_TrainerChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_TrainerChoice.Checked)
            {
                cb_AssocTrainer.Enabled = false;
            }
            else
            {
                cb_AssocTrainer.Enabled = true;
            }
        }
    }
}
