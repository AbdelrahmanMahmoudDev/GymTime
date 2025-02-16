namespace GymTime.Presentation
{
    partial class CustomerRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegistration));
            tb_FirstName = new Custom_Controls.GymTextBox();
            lbl_FirstName = new Custom_Controls.GymLabel();
            lbl_LastName = new Custom_Controls.GymLabel();
            tb_LastName = new Custom_Controls.GymTextBox();
            lbl_Username = new Custom_Controls.GymLabel();
            tb_Username = new Custom_Controls.GymTextBox();
            lbl_Password = new Custom_Controls.GymLabel();
            tb_Password = new Custom_Controls.GymTextBox();
            pictureBox1 = new PictureBox();
            cb_AssocTrainer = new Custom_Controls.GymComboBox();
            lbl_AssocTrainer = new Custom_Controls.GymLabel();
            cb_AssocSubPack = new Custom_Controls.GymComboBox();
            lbl_AssocSubPack = new Custom_Controls.GymLabel();
            btn_CustReg = new Custom_Controls.GymButton();
            chb_TrainerChoice = new CheckBox();
            chb_SubChoice = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_FirstName
            // 
            tb_FirstName.BackColor = Color.FromArgb(30, 30, 30);
            tb_FirstName.BorderStyle = BorderStyle.FixedSingle;
            tb_FirstName.Font = new Font("Segoe UI", 10F);
            tb_FirstName.ForeColor = Color.White;
            tb_FirstName.Location = new Point(203, 88);
            tb_FirstName.Name = "tb_FirstName";
            tb_FirstName.Size = new Size(331, 30);
            tb_FirstName.TabIndex = 1;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.BackColor = Color.Transparent;
            lbl_FirstName.Font = new Font("Segoe UI", 10F);
            lbl_FirstName.ForeColor = Color.White;
            lbl_FirstName.Location = new Point(18, 90);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(125, 29);
            lbl_FirstName.TabIndex = 2;
            lbl_FirstName.Text = "First Name*";
            // 
            // lbl_LastName
            // 
            lbl_LastName.BackColor = Color.Transparent;
            lbl_LastName.Font = new Font("Segoe UI", 10F);
            lbl_LastName.ForeColor = Color.White;
            lbl_LastName.Location = new Point(18, 128);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(125, 29);
            lbl_LastName.TabIndex = 4;
            lbl_LastName.Text = "Last Name*";
            // 
            // tb_LastName
            // 
            tb_LastName.BackColor = Color.FromArgb(30, 30, 30);
            tb_LastName.BorderStyle = BorderStyle.FixedSingle;
            tb_LastName.Font = new Font("Segoe UI", 10F);
            tb_LastName.ForeColor = Color.White;
            tb_LastName.Location = new Point(203, 128);
            tb_LastName.Name = "tb_LastName";
            tb_LastName.Size = new Size(331, 30);
            tb_LastName.TabIndex = 3;
            // 
            // lbl_Username
            // 
            lbl_Username.BackColor = Color.Transparent;
            lbl_Username.Font = new Font("Segoe UI", 10F);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(18, 168);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(125, 29);
            lbl_Username.TabIndex = 6;
            lbl_Username.Text = "Username*";
            // 
            // tb_Username
            // 
            tb_Username.BackColor = Color.FromArgb(30, 30, 30);
            tb_Username.BorderStyle = BorderStyle.FixedSingle;
            tb_Username.Font = new Font("Segoe UI", 10F);
            tb_Username.ForeColor = Color.White;
            tb_Username.Location = new Point(203, 168);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(331, 30);
            tb_Username.TabIndex = 5;
            // 
            // lbl_Password
            // 
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.Font = new Font("Segoe UI", 10F);
            lbl_Password.ForeColor = Color.White;
            lbl_Password.Location = new Point(18, 208);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(125, 29);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password*";
            // 
            // tb_Password
            // 
            tb_Password.BackColor = Color.FromArgb(30, 30, 30);
            tb_Password.BorderStyle = BorderStyle.FixedSingle;
            tb_Password.Font = new Font("Segoe UI", 10F);
            tb_Password.ForeColor = Color.White;
            tb_Password.Location = new Point(203, 208);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(331, 30);
            tb_Password.TabIndex = 7;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(544, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cb_AssocTrainer
            // 
            cb_AssocTrainer.BackColor = Color.FromArgb(30, 30, 30);
            cb_AssocTrainer.Font = new Font("Segoe UI", 10F);
            cb_AssocTrainer.ForeColor = Color.White;
            cb_AssocTrainer.FormattingEnabled = true;
            cb_AssocTrainer.Location = new Point(203, 262);
            cb_AssocTrainer.Name = "cb_AssocTrainer";
            cb_AssocTrainer.Size = new Size(331, 31);
            cb_AssocTrainer.TabIndex = 10;
            // 
            // lbl_AssocTrainer
            // 
            lbl_AssocTrainer.BackColor = Color.Transparent;
            lbl_AssocTrainer.Font = new Font("Segoe UI", 10F);
            lbl_AssocTrainer.ForeColor = Color.White;
            lbl_AssocTrainer.Location = new Point(13, 262);
            lbl_AssocTrainer.Name = "lbl_AssocTrainer";
            lbl_AssocTrainer.Size = new Size(184, 29);
            lbl_AssocTrainer.TabIndex = 11;
            lbl_AssocTrainer.Text = "Trainer of choice";
            // 
            // cb_AssocSubPack
            // 
            cb_AssocSubPack.BackColor = Color.FromArgb(30, 30, 30);
            cb_AssocSubPack.Font = new Font("Segoe UI", 10F);
            cb_AssocSubPack.ForeColor = Color.White;
            cb_AssocSubPack.FormattingEnabled = true;
            cb_AssocSubPack.Location = new Point(203, 356);
            cb_AssocSubPack.Name = "cb_AssocSubPack";
            cb_AssocSubPack.Size = new Size(331, 31);
            cb_AssocSubPack.TabIndex = 12;
            // 
            // lbl_AssocSubPack
            // 
            lbl_AssocSubPack.BackColor = Color.Transparent;
            lbl_AssocSubPack.Font = new Font("Segoe UI", 10F);
            lbl_AssocSubPack.ForeColor = Color.White;
            lbl_AssocSubPack.Location = new Point(13, 358);
            lbl_AssocSubPack.Name = "lbl_AssocSubPack";
            lbl_AssocSubPack.Size = new Size(184, 29);
            lbl_AssocSubPack.TabIndex = 13;
            lbl_AssocSubPack.Text = "Subscription Package";
            // 
            // btn_CustReg
            // 
            btn_CustReg.BackColor = Color.Silver;
            btn_CustReg.FlatAppearance.BorderColor = Color.White;
            btn_CustReg.FlatAppearance.BorderSize = 2;
            btn_CustReg.FlatStyle = FlatStyle.Flat;
            btn_CustReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_CustReg.ForeColor = Color.Black;
            btn_CustReg.Location = new Point(587, 348);
            btn_CustReg.Name = "btn_CustReg";
            btn_CustReg.Size = new Size(172, 71);
            btn_CustReg.TabIndex = 14;
            btn_CustReg.Text = "Register";
            btn_CustReg.UseVisualStyleBackColor = false;
            btn_CustReg.Click += btn_CustReg_Click;
            // 
            // chb_TrainerChoice
            // 
            chb_TrainerChoice.AutoSize = true;
            chb_TrainerChoice.Location = new Point(203, 311);
            chb_TrainerChoice.Name = "chb_TrainerChoice";
            chb_TrainerChoice.Size = new Size(168, 24);
            chb_TrainerChoice.TabIndex = 17;
            chb_TrainerChoice.Text = "I don't want a trainer";
            chb_TrainerChoice.UseVisualStyleBackColor = true;
            chb_TrainerChoice.CheckedChanged += chb_TrainerChoice_CheckedChanged;
            // 
            // chb_SubChoice
            // 
            chb_SubChoice.AutoSize = true;
            chb_SubChoice.Location = new Point(202, 404);
            chb_SubChoice.Name = "chb_SubChoice";
            chb_SubChoice.Size = new Size(205, 24);
            chb_SubChoice.TabIndex = 18;
            chb_SubChoice.Text = "I don't want a subscription";
            chb_SubChoice.UseVisualStyleBackColor = true;
            chb_SubChoice.CheckedChanged += chb_SubChoice_CheckedChanged;
            // 
            // CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chb_SubChoice);
            Controls.Add(chb_TrainerChoice);
            Controls.Add(btn_CustReg);
            Controls.Add(lbl_AssocSubPack);
            Controls.Add(cb_AssocSubPack);
            Controls.Add(lbl_AssocTrainer);
            Controls.Add(cb_AssocTrainer);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Password);
            Controls.Add(tb_Password);
            Controls.Add(lbl_Username);
            Controls.Add(tb_Username);
            Controls.Add(lbl_LastName);
            Controls.Add(tb_LastName);
            Controls.Add(lbl_FirstName);
            Controls.Add(tb_FirstName);
            Name = "CustomerRegistration";
            Text = "CustomerRegistration";
            FormClosed += CustomerRegistration_FormClosed;
            Load += CustomerRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Custom_Controls.GymTextBox tb_FirstName;
        private Custom_Controls.GymLabel lbl_FirstName;
        private Custom_Controls.GymLabel lbl_LastName;
        private Custom_Controls.GymTextBox tb_LastName;
        private Custom_Controls.GymLabel lbl_Username;
        private Custom_Controls.GymTextBox tb_Username;
        private Custom_Controls.GymLabel lbl_Password;
        private Custom_Controls.GymTextBox tb_Password;
        private PictureBox pictureBox1;
        private Custom_Controls.GymComboBox cb_AssocTrainer;
        private Custom_Controls.GymLabel lbl_AssocTrainer;
        private Custom_Controls.GymComboBox cb_AssocSubPack;
        private Custom_Controls.GymLabel lbl_AssocSubPack;
        private Custom_Controls.GymButton btn_CustReg;
        private CheckBox chb_TrainerChoice;
        private CheckBox chb_SubChoice;
    }
}