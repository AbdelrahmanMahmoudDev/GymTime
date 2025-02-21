namespace GymTime.Presentation
{
    partial class CustomerDash
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
            gymLabel1 = new Custom_Controls.GymLabel();
            SuspendLayout();
            // 
            // gymLabel1
            // 
            gymLabel1.BackColor = Color.Transparent;
            gymLabel1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gymLabel1.ForeColor = Color.White;
            gymLabel1.Location = new Point(13, 62);
            gymLabel1.Name = "gymLabel1";
            gymLabel1.Size = new Size(774, 68);
            gymLabel1.TabIndex = 1;
            gymLabel1.Text = "Hello, ";
            // 
            // CustomerDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gymLabel1);
            Name = "CustomerDash";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Custom_Controls.GymLabel gymLabel1;
    }
}