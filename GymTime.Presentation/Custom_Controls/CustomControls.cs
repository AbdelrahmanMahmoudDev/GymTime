using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTime.Presentation.Custom_Controls
{
    [ToolboxItem(true)]
    public class GymButton : Button
    {
        public GymButton()
        {
            // Default styling
            this.Size = new Size(120, 40);
            this.BackColor = Color.Silver;
            this.ForeColor = Color.Black;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.FlatAppearance.BorderSize = 2;
            this.FlatAppearance.BorderColor = Color.White;

            // Hover effect
            this.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(100, 100, 100);
            this.MouseLeave += (s, e) => this.BackColor = Color.Silver;
        }
    }

    [ToolboxItem(true)]
    public class GymTextBox : TextBox
    {
        public GymTextBox()
        {
            this.BackColor = Color.FromArgb(30, 30, 30); // Dark background
            this.ForeColor = Color.White; // Light text
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font("Segoe UI", 10);
        }
    }

    [ToolboxItem(true)]
    public class GymRadioButton : RadioButton
    {
        public GymRadioButton()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.Font = new Font("Segoe UI", 10);
        }
    }

    [ToolboxItem(true)]
    public class GymLabel : Label
    {
        public GymLabel()
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.Transparent;
            this.Font = new Font("Segoe UI", 10);
        }
    }

    [ToolboxItem(true)]
    public class GymGroupBox : GroupBox
    {
        public GymGroupBox()
        {
            this.BackColor = Color.FromArgb(30, 30, 30); // Dark background
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
        }
    }
    [ToolboxItem(true)]
    public class GymComboBox : ComboBox
    {
        public GymComboBox()
        {
            this.BackColor = Color.FromArgb(30, 30, 30); // Dark background
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10);

        }
    }

    [ToolboxItem(true)]
    public class GymNumericUpDown : NumericUpDown
    {
        public GymNumericUpDown()
        {
            this.BackColor = Color.FromArgb(30, 30, 30); // Dark background
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
        }
    }
}
