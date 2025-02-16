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
    public partial class TrainerRegistration : BaseForm
    {
        GymTimeContext context = new GymTimeContext();
        public TrainerRegistration()
        {
            InitializeComponent();
            var Managers = context.Managers.Select(man => new { ManagerId = man.ManagerId, FullName = $"{man.FirstName} {man.LastName}" }).ToList();
            cb_Manager.DataSource = Managers;
            cb_Manager.ValueMember = "ManagerId";
            cb_Manager.DisplayMember = "FullName";
        }

        private async void btn_TrainReg_Click(object sender, EventArgs e)
        {
            var NewTrainData = new Trainer()
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                ManagerId = (int?)cb_Manager.SelectedValue,
            };

            (string hash, string salt) = PasswordHasher.HashPassword(tb_Password.Text);
            var NewTrainPass = new TrainerPassword()
            {
                TrainerUsername = tb_Username.Text,
                PasswordHash = hash,
                PasswordSalt = salt
            };

            using var transaction = await context.Database.BeginTransactionAsync();
            try
            {
                context.Trainers.Add(NewTrainData);
                await context.SaveChangesAsync();

                var items = await context.Trainers.Select(t => t.TrainerId)
                    .ToListAsync();

                NewTrainPass.TrainerPasswordId = items.OrderDescending().FirstOrDefault();

                context.TrainerPasswords.Add(NewTrainPass);
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
