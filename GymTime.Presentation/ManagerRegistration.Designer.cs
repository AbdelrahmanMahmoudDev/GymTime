namespace GymTime.Presentation
{
    partial class ManagerRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerRegistration));
            btn_ManReg = new Custom_Controls.GymButton();
            pictureBox1 = new PictureBox();
            lbl_Password = new Custom_Controls.GymLabel();
            tb_Password = new Custom_Controls.GymTextBox();
            lbl_Username = new Custom_Controls.GymLabel();
            tb_Username = new Custom_Controls.GymTextBox();
            lbl_LastName = new Custom_Controls.GymLabel();
            tb_LastName = new Custom_Controls.GymTextBox();
            lbl_FirstName = new Custom_Controls.GymLabel();
            tb_FirstName = new Custom_Controls.GymTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_ManReg
            // 
            btn_ManReg.BackColor = Color.Silver;
            btn_ManReg.FlatAppearance.BorderColor = Color.White;
            btn_ManReg.FlatAppearance.BorderSize = 2;
            btn_ManReg.FlatStyle = FlatStyle.Flat;
            btn_ManReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_ManReg.ForeColor = Color.Black;
            btn_ManReg.Location = new Point(302, 366);
            btn_ManReg.Name = "btn_ManReg";
            btn_ManReg.Size = new Size(172, 71);
            btn_ManReg.TabIndex = 32;
            btn_ManReg.Text = "Register";
            btn_ManReg.UseVisualStyleBackColor = false;
            btn_ManReg.Click += btn_ManReg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // lbl_Password
            // 
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI", 10F);
            lbl_Password.ForeColor = Color.White;
            lbl_Password.Location = new Point(18, 295);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(125, 29);
            lbl_Password.TabIndex = 26;
            lbl_Password.Text = "Password*";
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(30, 30, 30);
            tb_Password.BorderStyle = BorderStyle.FixedSingle;
            tb_Password.Font = new Font("Segoe UI", 10F);
            tb_Password.ForeColor = Color.White;
            tb_Password.Location = new Point(203, 295);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(331, 30);
            tb_Password.TabIndex = 25;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Username
            // 
            lbl_Username.BackColor = Color.Transparent;
            lbl_Username.Font = new Font("Segoe UI", 10F);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(18, 238);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(125, 29);
            lbl_Username.TabIndex = 24;
            lbl_Username.Text = "Username*";
            // 
            // tb_Username
            // 
            tb_Username.BackColor = Color.FromArgb(30, 30, 30);
            tb_Username.BorderStyle = BorderStyle.FixedSingle;
            tb_Username.Font = new Font("Segoe UI", 10F);
            tb_Username.ForeColor = Color.White;
            tb_Username.Location = new Point(203, 238);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(331, 30);
            tb_Username.TabIndex = 23;
            // 
            // lbl_LastName
            // 
            lbl_LastName.BackColor = Color.Transparent;
            lbl_LastName.Font = new Font("Segoe UI", 10F);
            lbl_LastName.ForeColor = Color.White;
            lbl_LastName.Location = new Point(18, 174);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(125, 29);
            lbl_LastName.TabIndex = 22;
            lbl_LastName.Text = "Last Name*";
            // 
            // tb_LastName
            // 
            tb_LastName.BackColor = Color.FromArgb(30, 30, 30);
            tb_LastName.BorderStyle = BorderStyle.FixedSingle;
            tb_LastName.Font = new Font("Segoe UI", 10F);
            tb_LastName.ForeColor = Color.White;
            tb_LastName.Location = new Point(203, 174);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(331, 30);
            tb_LastName.TabIndex = 21;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.BackColor = Color.Transparent;
            lbl_FirstName.Font = new Font("Segoe UI", 10F);
            lbl_FirstName.ForeColor = Color.White;
            lbl_FirstName.Location = new Point(18, 113);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(125, 29);
            lbl_FirstName.TabIndex = 20;
            lbl_FirstName.Text = "First Name*";
            // 
            // tb_FirstName
            // 
            tb_FirstName.BackColor = Color.FromArgb(30, 30, 30);
            tb_FirstName.BorderStyle = BorderStyle.FixedSingle;
            tb_FirstName.Font = new Font("Segoe UI", 10F);
            tb_FirstName.ForeColor = Color.White;
            tb_FirstName.Location = new Point(203, 111);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(331, 30);
            tb_FirstName.TabIndex = 19;
            // 
            // ManagerRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ManReg);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Password);
            Controls.Add(tb_Password);
            Controls.Add(lbl_Username);
            Controls.Add(tb_Username);
            Controls.Add(lbl_LastName);
            Controls.Add(tb_LastName);
            Controls.Add(lbl_FirstName);
            Controls.Add(tb_FirstName);
            Name = "ManagerRegistration";
            Text = "ManagerRegistration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.GymButton btn_ManReg;
        private PictureBox pictureBox1;
        private Custom_Controls.GymLabel lbl_Password;
        private Custom_Controls.GymTextBox tb_Password;
        private Custom_Controls.GymLabel lbl_Username;
        private Custom_Controls.GymTextBox tb_Username;
        private Custom_Controls.GymLabel lbl_LastName;
        private Custom_Controls.GymTextBox tb_LastName;
        private Custom_Controls.GymLabel lbl_FirstName;
        private Custom_Controls.GymTextBox tb_FirstName;
    }
}