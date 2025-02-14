using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Presentation
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            // Set dark theme colors
            this.BackColor = Color.FromArgb(15, 15, 15); // Dark background
            this.ForeColor = Color.White; // White text

            // Customizing the title bar
            this.FormBorderStyle = FormBorderStyle.None; // No default Windows title bar
            this.Padding = new Padding(10); // Adds a little padding for aesthetics
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "gym time".ToUpper();
            this.Size = new Size() { Height = 720, Width = 1280 };
            // Custom close, minimize, maximize buttons
            CreateCustomTitleBar();
        }

        private void CreateCustomTitleBar()
        {
            Panel titleBar = new Panel
            {
                Height = 50,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(25, 25, 25), // Darker title bar
            };
            this.Controls.Add(titleBar);

            Label title = new Label
            {
                Text = this.Text,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Left = 15,
                Top = 10
            };
            titleBar.Controls.Add(title);

            Button btnClose = CreateTitleBarButton("X", Color.FromArgb(200, 50, 50));
            btnClose.Click += (s, e) => this.Close();

            Button btnMinimize = CreateTitleBarButton("_", Color.FromArgb(50, 200, 50));
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            Button btnMaximize = CreateTitleBarButton("🗖", Color.FromArgb(50, 100, 200));
            btnMaximize.Click += (s, e) =>
            {
                this.WindowState = this.WindowState == FormWindowState.Maximized ?
                                   FormWindowState.Normal : FormWindowState.Maximized;
            };

            const int ButtonSpace = 65;

            // Position buttons
            btnClose.Left = this.Width - ButtonSpace;
            btnMinimize.Left = btnClose.Left - ButtonSpace - 5;
            btnMaximize.Left = btnMinimize.Left - ButtonSpace - 10;

            // Resize dynamically
            this.Resize += (s, e) =>
            {
                btnClose.Left = this.Width - ButtonSpace;
                btnMinimize.Left = btnClose.Left - ButtonSpace - 5;
                btnMaximize.Left = btnMinimize.Left - ButtonSpace - 10;
            };

            titleBar.Controls.Add(btnClose);
            titleBar.Controls.Add(btnMinimize);
            titleBar.Controls.Add(btnMaximize);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // BaseForm
            // 
            ClientSize = new Size(1262, 673);
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
        }

        private Button CreateTitleBarButton(string text, Color bgColor)
        {
            return new Button
            {
                Text = text,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Size = new Size(35, 30),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = bgColor,
                Top = 5
            };
        }
    }
}
