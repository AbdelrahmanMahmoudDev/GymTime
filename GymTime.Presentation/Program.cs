
namespace GymTime.Presentation
{
    internal static class Program
    {
        public static Form1 StartingScreen = new Form1();
        public static RegisterScreen RegScreen = new RegisterScreen();
        public static CustomerRegistration CustRegScreen = new CustomerRegistration();
        static void LoadScreens()
        {

        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(StartingScreen);
        }
    }
}