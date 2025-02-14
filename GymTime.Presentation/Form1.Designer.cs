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
            btn_Register.Location = new Point(900, 607);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(243, 50);
            btn_Register.TabIndex = 1;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = false;
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
            btn_Login.Location = new Point(900, 551);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(243, 50);
            btn_Login.TabIndex = 3;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1280, 720);
            Controls.Add(btn_Login);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Register);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.GymButton btn_Register;
        private PictureBox pictureBox1;
        private Custom_Controls.GymButton btn_Login;
    }
}
