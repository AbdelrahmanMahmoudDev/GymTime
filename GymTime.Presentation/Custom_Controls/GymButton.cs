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
            this.MouseLeave += (s, e) => this.BackColor = Color.FromArgb(50, 50, 50);
        }
    }
}
