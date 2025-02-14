namespace GymTime.Presentation
{
    partial class RegisterScreen
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
            lbl_Username = new Custom_Controls.GymLabel();
            tb_Username = new Custom_Controls.GymTextBox();
            tb_Password = new Custom_Controls.GymTextBox();
            lbl_Password = new Custom_Controls.GymLabel();
            btn_Register = new Custom_Controls.GymButton();
            gb_UserTypes = new Custom_Controls.GymGroupBox();
            rb_Customer = new Custom_Controls.GymRadioButton();
            rb_Manager = new Custom_Controls.GymRadioButton();
            rb_Trainer = new Custom_Controls.GymRadioButton();
            gb_UserTypes.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.BackColor = Color.Transparent;
            lbl_Username.Font = new Font("Segoe UI", 10F);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(56, 117);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(93, 29);
            lbl_Username.TabIndex = 1;
            lbl_Username.Text = "Username";
            lbl_Username.UseCompatibleTextRendering = true;
            // 
            // tb_Username
            // 
            tb_Username.BackColor = Color.FromArgb(30, 30, 30);
            tb_Username.BorderStyle = BorderStyle.FixedSingle;
            tb_Username.Font = new Font("Segoe UI", 10F);
            tb_Username.ForeColor = Color.White;
            tb_Username.Location = new Point(56, 149);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(503, 30);
            tb_Username.TabIndex = 2;
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(30, 30, 30);
            tb_Password.BorderStyle = BorderStyle.FixedSingle;
            tb_Password.Font = new Font("Segoe UI", 10F);
            tb_Password.ForeColor = Color.White;
            tb_Password.Location = new Point(56, 253);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(503, 30);
            tb_Password.TabIndex = 4;
            // 
            // lbl_Password
            // 
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI", 10F);
            lbl_Password.ForeColor = Color.White;
            lbl_Password.Location = new Point(56, 221);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(93, 29);
            lbl_Password.TabIndex = 3;
            lbl_Password.Text = "Password";
            lbl_Password.UseCompatibleTextRendering = true;
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.Silver;
            btn_Register.FlatAppearance.BorderColor = Color.White;
            btn_Register.FlatAppearance.BorderSize = 2;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Register.ForeColor = Color.Black;
            btn_Register.Location = new Point(236, 417);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(150, 50);
            btn_Register.TabIndex = 5;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            // 
            // gb_UserTypes
            // 
            gb_UserTypes.BackColor = Color.FromArgb(30, 30, 30);
            gb_UserTypes.Controls.Add(rb_Trainer);
            gb_UserTypes.Controls.Add(rb_Manager);
            gb_UserTypes.Controls.Add(rb_Customer);
            gb_UserTypes.Font = new Font("Segoe UI", 10F);
            gb_UserTypes.ForeColor = Color.White;
            gb_UserTypes.Location = new Point(56, 329);
            gb_UserTypes.Name = "gb_UserTypes";
            gb_UserTypes.Size = new Size(503, 66);
            gb_UserTypes.TabIndex = 6;
            gb_UserTypes.TabStop = false;
            gb_UserTypes.Text = "User Type";
            // 
            // rb_Customer
            // 
            rb_Customer.BackColor = Color.FromArgb(30, 30, 30);
            rb_Customer.Font = new Font("Segoe UI", 10F);
            rb_Customer.ForeColor = Color.White;
            rb_Customer.Location = new Point(6, 29);
            rb_Customer.Name = "rb_Customer";
            rb_Customer.Size = new Size(130, 30);
            rb_Customer.TabIndex = 0;
            rb_Customer.TabStop = true;
            rb_Customer.Text = "Customer";
            rb_Customer.UseVisualStyleBackColor = false;
            // 
            // rb_Manager
            // 
            rb_Manager.BackColor = Color.FromArgb(30, 30, 30);
            rb_Manager.Font = new Font("Segoe UI", 10F);
            rb_Manager.ForeColor = Color.White;
            rb_Manager.Location = new Point(200, 29);
            rb_Manager.Name = "rb_Manager";
            rb_Manager.Size = new Size(130, 30);
            rb_Manager.TabIndex = 1;
            rb_Manager.TabStop = true;
            rb_Manager.Text = "Manager";
            rb_Manager.UseVisualStyleBackColor = false;
            // 
            // rb_Trainer
            // 
            rb_Trainer.BackColor = Color.FromArgb(30, 30, 30);
            rb_Trainer.Font = new Font("Segoe UI", 10F);
            rb_Trainer.ForeColor = Color.White;
            rb_Trainer.Location = new Point(367, 29);
            rb_Trainer.Name = "rb_Trainer";
            rb_Trainer.Size = new Size(130, 30);
            rb_Trainer.TabIndex = 2;
            rb_Trainer.TabStop = true;
            rb_Trainer.Text = "Trainer";
            rb_Trainer.TextAlign = ContentAlignment.BottomCenter;
            rb_Trainer.UseVisualStyleBackColor = false;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 480);
            Controls.Add(gb_UserTypes);
            Controls.Add(btn_Register);
            Controls.Add(tb_Password);
            Controls.Add(lbl_Password);
            Controls.Add(tb_Username);
            Controls.Add(lbl_Username);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            gb_UserTypes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.GymLabel lbl_Username;
        private Custom_Controls.GymTextBox tb_Username;
        private Custom_Controls.GymTextBox tb_Password;
        private Custom_Controls.GymLabel lbl_Password;
        private Custom_Controls.GymButton btn_Register;
        private Custom_Controls.GymGroupBox gb_UserTypes;
        private Custom_Controls.GymRadioButton rb_Trainer;
        private Custom_Controls.GymRadioButton rb_Manager;
        private Custom_Controls.GymRadioButton rb_Customer;
    }
}