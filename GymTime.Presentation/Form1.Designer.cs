namespace GymTime.Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Register = new Custom_Controls.GymButton();
            pictureBox1 = new PictureBox();
            btn_Login = new Custom_Controls.GymButton();
            tb_Username = new Custom_Controls.GymTextBox();
            lbl_Username = new Custom_Controls.GymLabel();
            lbl_Password = new Custom_Controls.GymLabel();
            tb_Password = new Custom_Controls.GymTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Register
            // 
            btn_Register.BackColor = Color.Silver;
            btn_Register.FlatAppearance.BorderColor = Color.White;
            btn_Register.FlatAppearance.BorderSize = 2;
            btn_Register.FlatStyle = FlatStyle.Flat;
            btn_Register.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Register.ForeColor = Color.Black;
            btn_Register.Location = new Point(895, 490);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(243, 50);
            btn_Register.TabIndex = 1;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(719, 640);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Silver;
            btn_Login.FlatAppearance.BorderColor = Color.White;
            btn_Login.FlatAppearance.BorderSize = 2;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Login.ForeColor = Color.Black;
            btn_Login.Location = new Point(895, 434);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(243, 50);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // tb_Username
            // 
            tb_Username.BackColor = Color.FromArgb(30, 30, 30);
            tb_Username.BorderStyle = BorderStyle.FixedSingle;
            tb_Username.Font = new Font("Segoe UI", 10F);
            tb_Username.ForeColor = Color.White;
            tb_Username.Location = new Point(858, 185);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(311, 30);
            tb_Username.TabIndex = 4;
            // 
            // lbl_Username
            // 
            lbl_Username.BackColor = Color.Transparent;
            lbl_Username.Font = new Font("Segoe UI", 10F);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(858, 153);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(125, 29);
            lbl_Username.TabIndex = 5;
            lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI", 10F);
            lbl_Password.ForeColor = Color.White;
            lbl_Password.Location = new Point(858, 296);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(125, 29);
            lbl_Password.TabIndex = 7;
            lbl_Password.Text = "Password";
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(30, 30, 30);
            tb_Password.BorderStyle = BorderStyle.FixedSingle;
            tb_Password.Font = new Font("Segoe UI", 10F);
            tb_Password.ForeColor = Color.White;
            tb_Password.Location = new Point(858, 328);
            tb_Password.Name = "tb_Password";
            tb_Password.ScrollBars = ScrollBars.Both;
            tb_Password.Size = new Size(311, 30);
            tb_Password.TabIndex = 6;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 720);
            Controls.Add(lbl_Password);
            Controls.Add(tb_Password);
            Controls.Add(lbl_Username);
            Controls.Add(tb_Username);
            Controls.Add(btn_Login);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Register);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.GymButton btn_Register;
        private PictureBox pictureBox1;
        private Custom_Controls.GymButton btn_Login;
        private Custom_Controls.GymTextBox tb_Username;
        private Custom_Controls.GymLabel lbl_Username;
        private Custom_Controls.GymLabel lbl_Password;
        private Custom_Controls.GymTextBox tb_Password;
    }
}
