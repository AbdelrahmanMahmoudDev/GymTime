namespace GymTime.Presentation
{
    partial class TrainerRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerRegistration));
            btn_TrainReg = new Custom_Controls.GymButton();
            pictureBox1 = new PictureBox();
            lbl_Password = new Custom_Controls.GymLabel();
            tb_Password = new Custom_Controls.GymTextBox();
            lbl_Username = new Custom_Controls.GymLabel();
            tb_Username = new Custom_Controls.GymTextBox();
            lbl_LastName = new Custom_Controls.GymLabel();
            tb_LastName = new Custom_Controls.GymTextBox();
            lbl_FirstName = new Custom_Controls.GymLabel();
            tb_FirstName = new Custom_Controls.GymTextBox();
            nud_Sal = new Custom_Controls.GymNumericUpDown();
            gymLabel1 = new Custom_Controls.GymLabel();
            nud_kpi = new Custom_Controls.GymNumericUpDown();
            gymLabel2 = new Custom_Controls.GymLabel();
            gymLabel3 = new Custom_Controls.GymLabel();
            cb_Manager = new Custom_Controls.GymComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Sal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_kpi).BeginInit();
            SuspendLayout();
            // 
            // btn_TrainReg
            // 
            btn_TrainReg.BackColor = Color.Silver;
            btn_TrainReg.FlatAppearance.BorderColor = Color.White;
            btn_TrainReg.FlatAppearance.BorderSize = 2;
            btn_TrainReg.FlatStyle = FlatStyle.Flat;
            btn_TrainReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_TrainReg.ForeColor = Color.Black;
            btn_TrainReg.Location = new Point(590, 329);
            btn_TrainReg.Name = "btn_TrainReg";
            btn_TrainReg.Size = new Size(172, 71);
            btn_TrainReg.TabIndex = 42;
            btn_TrainReg.Text = "Register";
            btn_TrainReg.UseVisualStyleBackColor = false;
            btn_TrainReg.Click += btn_TrainReg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // lbl_Password
            // 
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI", 10F);
            lbl_Password.ForeColor = Color.White;
            lbl_Password.Location = new Point(13, 244);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(125, 29);
            lbl_Password.TabIndex = 40;
            lbl_Password.Text = "Password*";
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(30, 30, 30);
            tb_Password.BorderStyle = BorderStyle.FixedSingle;
            tb_Password.Font = new Font("Segoe UI", 10F);
            tb_Password.ForeColor = Color.White;
            tb_Password.Location = new Point(198, 244);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(331, 30);
            tb_Password.TabIndex = 39;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Username
            // 
            lbl_Username.BackColor = Color.Transparent;
            lbl_Username.Font = new Font("Segoe UI", 10F);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(13, 202);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(125, 29);
            lbl_Username.TabIndex = 38;
            lbl_Username.Text = "Username*";
            // 
            // tb_Username
            // 
            tb_Username.BackColor = Color.FromArgb(30, 30, 30);
            tb_Username.BorderStyle = BorderStyle.FixedSingle;
            tb_Username.Font = new Font("Segoe UI", 10F);
            tb_Username.ForeColor = Color.White;
            tb_Username.Location = new Point(198, 200);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(331, 30);
            tb_Username.TabIndex = 37;
            // 
            // lbl_LastName
            // 
            lbl_LastName.BackColor = Color.Transparent;
            lbl_LastName.Font = new Font("Segoe UI", 10F);
            lbl_LastName.ForeColor = Color.White;
            lbl_LastName.Location = new Point(13, 154);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(125, 29);
            lbl_LastName.TabIndex = 36;
            lbl_LastName.Text = "Last Name*";
            // 
            // tb_LastName
            // 
            tb_LastName.BackColor = Color.FromArgb(30, 30, 30);
            tb_LastName.BorderStyle = BorderStyle.FixedSingle;
            tb_LastName.Font = new Font("Segoe UI", 10F);
            tb_LastName.ForeColor = Color.White;
            tb_LastName.Location = new Point(198, 154);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(331, 30);
            tb_LastName.TabIndex = 35;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.BackColor = Color.Transparent;
            lbl_FirstName.Font = new Font("Segoe UI", 10F);
            lbl_FirstName.ForeColor = Color.White;
            lbl_FirstName.Location = new Point(13, 102);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(125, 29);
            lbl_FirstName.TabIndex = 34;
            lbl_FirstName.Text = "First Name*";
            // 
            // tb_FirstName
            // 
            tb_FirstName.BackColor = Color.FromArgb(30, 30, 30);
            tb_FirstName.BorderStyle = BorderStyle.FixedSingle;
            tb_FirstName.Font = new Font("Segoe UI", 10F);
            tb_FirstName.ForeColor = Color.White;
            tb_FirstName.Location = new Point(198, 100);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(331, 30);
            tb_FirstName.TabIndex = 33;
            // 
            // nud_Sal
            // 
            nud_Sal.BackColor = Color.FromArgb(30, 30, 30);
            nud_Sal.DecimalPlaces = 2;
            nud_Sal.Font = new Font("Segoe UI", 10F);
            nud_Sal.ForeColor = Color.White;
            nud_Sal.Location = new Point(198, 290);
            nud_Sal.Name = "nud_Sal";
            nud_Sal.Size = new Size(331, 30);
            nud_Sal.TabIndex = 43;
            // 
            // gymLabel1
            // 
            gymLabel1.BackColor = Color.Transparent;
            gymLabel1.Font = new Font("Segoe UI", 10F);
            gymLabel1.ForeColor = Color.White;
            gymLabel1.Location = new Point(13, 290);
            gymLabel1.Name = "gymLabel1";
            gymLabel1.Size = new Size(125, 29);
            gymLabel1.TabIndex = 44;
            gymLabel1.Text = "Salary*";
            // 
            // nud_kpi
            // 
            nud_kpi.BackColor = Color.FromArgb(30, 30, 30);
            nud_kpi.DecimalPlaces = 2;
            nud_kpi.Font = new Font("Segoe UI", 10F);
            nud_kpi.ForeColor = Color.White;
            nud_kpi.Location = new Point(198, 343);
            nud_kpi.Name = "nud_kpi";
            nud_kpi.Size = new Size(331, 30);
            nud_kpi.TabIndex = 45;
            // 
            // gymLabel2
            // 
            gymLabel2.BackColor = Color.Transparent;
            gymLabel2.Font = new Font("Segoe UI", 10F);
            gymLabel2.ForeColor = Color.White;
            gymLabel2.Location = new Point(13, 343);
            gymLabel2.Name = "gymLabel2";
            gymLabel2.Size = new Size(125, 29);
            gymLabel2.TabIndex = 46;
            gymLabel2.Text = "KPI*";
            // 
            // gymLabel3
            // 
            gymLabel3.BackColor = Color.Transparent;
            gymLabel3.Font = new Font("Segoe UI", 10F);
            gymLabel3.ForeColor = Color.White;
            gymLabel3.Location = new Point(13, 394);
            gymLabel3.Name = "gymLabel3";
            gymLabel3.Size = new Size(125, 29);
            gymLabel3.TabIndex = 47;
            gymLabel3.Text = "Manager*";
            // 
            // cb_Manager
            // 
            cb_Manager.BackColor = Color.FromArgb(30, 30, 30);
            cb_Manager.Font = new Font("Segoe UI", 10F);
            cb_Manager.ForeColor = Color.White;
            cb_Manager.FormattingEnabled = true;
            cb_Manager.Location = new Point(198, 394);
            cb_Manager.Name = "cb_Manager";
            cb_Manager.Size = new Size(331, 31);
            cb_Manager.TabIndex = 48;
            // 
            // TrainerRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_Manager);
            Controls.Add(gymLabel3);
            Controls.Add(gymLabel2);
            Controls.Add(nud_kpi);
            Controls.Add(gymLabel1);
            Controls.Add(nud_Sal);
            Controls.Add(btn_TrainReg);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Password);
            Controls.Add(tb_Password);
            Controls.Add(lbl_Username);
            Controls.Add(tb_Username);
            Controls.Add(lbl_LastName);
            Controls.Add(tb_LastName);
            Controls.Add(lbl_FirstName);
            Controls.Add(tb_FirstName);
            Name = "TrainerRegistration";
            Text = "TrainerRegistration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Sal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_kpi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.GymButton btn_TrainReg;
        private PictureBox pictureBox1;
        private Custom_Controls.GymLabel lbl_Password;
        private Custom_Controls.GymTextBox tb_Password;
        private Custom_Controls.GymLabel lbl_Username;
        private Custom_Controls.GymTextBox tb_Username;
        private Custom_Controls.GymLabel lbl_LastName;
        private Custom_Controls.GymTextBox tb_LastName;
        private Custom_Controls.GymLabel lbl_FirstName;
        private Custom_Controls.GymTextBox tb_FirstName;
        private Custom_Controls.GymNumericUpDown nud_Sal;
        private Custom_Controls.GymLabel gymLabel1;
        private Custom_Controls.GymNumericUpDown nud_kpi;
        private Custom_Controls.GymLabel gymLabel2;
        private Custom_Controls.GymLabel gymLabel3;
        private Custom_Controls.GymComboBox cb_Manager;
    }
}