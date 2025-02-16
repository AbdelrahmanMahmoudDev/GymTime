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
    public partial class ManagerRegistration : BaseForm
    {
        GymTimeContext context = new GymTimeContext();
        public ManagerRegistration()
        {
            InitializeComponent();

        }

        private async void btn_ManReg_Click(object sender, EventArgs e)
        {
            // prep data
            var NewMangData = new Manager()
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
            };
            (string hash, string salt) = PasswordHasher.HashPassword(tb_Password.Text);
            var NewMangPass = new ManagerPassword()
            {
                ManagerUsername = tb_Username.Text,
                PasswordHash = hash,
                PasswordSalt = salt
            };

            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                context.Managers.Add(NewMangData);
                await context.SaveChangesAsync();

                var items = await context.Managers
                                         .Select(m => m.ManagerId)
                                         .ToListAsync();

                NewMangPass.ManagerPasswordId = items
                                        .OrderDescending()
                                        .FirstOrDefault();

                context.ManagerPasswords.Add(NewMangPass);
                await context.SaveChangesAsync();
                await transaction.CommitAsync();

                MessageBox.Show("User Created!");
                Program.StartingScreen.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
