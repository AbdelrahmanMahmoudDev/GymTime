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
            btn_PreCustomer = new Custom_Controls.GymButton();
            btn_PreManager = new Custom_Controls.GymButton();
            btn_PreTrainer = new Custom_Controls.GymButton();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.BackColor = Color.Transparent;
            lbl_Username.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.ForeColor = Color.White;
            lbl_Username.Location = new Point(147, 134);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(383, 166);
            lbl_Username.TabIndex = 1;
            lbl_Username.Text = "Who Are You ?";
            lbl_Username.UseCompatibleTextRendering = true;
            // 
            // btn_PreCustomer
            // 
            btn_PreCustomer.BackColor = Color.Silver;
            btn_PreCustomer.DialogResult = DialogResult.Abort;
            btn_PreCustomer.FlatAppearance.BorderColor = Color.White;
            btn_PreCustomer.FlatAppearance.BorderSize = 2;
            btn_PreCustomer.FlatStyle = FlatStyle.Flat;
            btn_PreCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_PreCustomer.ForeColor = Color.Black;
            btn_PreCustomer.Location = new Point(234, 359);
            btn_PreCustomer.Name = "btn_PreCustomer";
            btn_PreCustomer.RightToLeft = RightToLeft.Yes;
            btn_PreCustomer.Size = new Size(150, 50);
            btn_PreCustomer.TabIndex = 5;
            btn_PreCustomer.Text = "Customer";
            btn_PreCustomer.UseVisualStyleBackColor = false;
            btn_PreCustomer.Click += btn_PreCustomer_Click;
            // 
            // btn_PreManager
            // 
            btn_PreManager.BackColor = Color.Silver;
            btn_PreManager.DialogResult = DialogResult.Abort;
            btn_PreManager.FlatAppearance.BorderColor = Color.White;
            btn_PreManager.FlatAppearance.BorderSize = 2;
            btn_PreManager.FlatStyle = FlatStyle.Flat;
            btn_PreManager.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_PreManager.ForeColor = Color.Black;
            btn_PreManager.Location = new Point(234, 245);
            btn_PreManager.Name = "btn_PreManager";
            btn_PreManager.RightToLeft = RightToLeft.Yes;
            btn_PreManager.Size = new Size(150, 50);
            btn_PreManager.TabIndex = 6;
            btn_PreManager.Text = "Manager";
            btn_PreManager.UseVisualStyleBackColor = false;
            btn_PreManager.Click += btn_PreManager_Click;
            // 
            // btn_PreTrainer
            // 
            btn_PreTrainer.BackColor = Color.Silver;
            btn_PreTrainer.DialogResult = DialogResult.Abort;
            btn_PreTrainer.FlatAppearance.BorderColor = Color.White;
            btn_PreTrainer.FlatAppearance.BorderSize = 2;
            btn_PreTrainer.FlatStyle = FlatStyle.Flat;
            btn_PreTrainer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_PreTrainer.ForeColor = Color.Black;
            btn_PreTrainer.Location = new Point(234, 303);
            btn_PreTrainer.Name = "btn_PreTrainer";
            btn_PreTrainer.RightToLeft = RightToLeft.Yes;
            btn_PreTrainer.Size = new Size(150, 50);
            btn_PreTrainer.TabIndex = 7;
            btn_PreTrainer.Text = "Trainer";
            btn_PreTrainer.UseVisualStyleBackColor = false;
            btn_PreTrainer.Click += btn_PreTrainer_Click;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 480);
            Controls.Add(btn_PreTrainer);
            Controls.Add(btn_PreManager);
            Controls.Add(btn_PreCustomer);
            Controls.Add(lbl_Username);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.GymLabel lbl_Username;
        private Custom_Controls.GymTextBox tb_Username;
        private Custom_Controls.GymTextBox tb_Password;
        private Custom_Controls.GymLabel lbl_Password;
        private Custom_Controls.GymButton btn_PreCustomer;
        private Custom_Controls.GymButton btn_PreManager;
        private Custom_Controls.GymButton btn_PreTrainer;
        private Custom_Controls.GymGroupBox gb_UserTypes;
        private Custom_Controls.GymRadioButton rb_Trainer;
        private Custom_Controls.GymRadioButton rb_Manager;
        private Custom_Controls.GymRadioButton rb_Customer;
    }
}