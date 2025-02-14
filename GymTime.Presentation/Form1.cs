
namespace GymTime.Presentation
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var Reg = new RegisterScreen();
            Reg.ShowDialog();
        }
    }
}
