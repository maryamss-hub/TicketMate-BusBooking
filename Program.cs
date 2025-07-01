#nullable disable
using System;
using System.Windows.Forms;

namespace TicketMate
{
    internal static class Program
    {
        public static WelcomeForm WelcomeInstance;
        public static LoginForm LoginInstance;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WelcomeInstance = new WelcomeForm();
            Application.Run(WelcomeInstance);
        }

        public static void ShowForm(Form formToShow, Form currentForm = null)
        {
            currentForm?.Hide();
            formToShow.Show();
        }

        public static void ShowLoginForm(Form currentForm = null)
        {
            LoginInstance = new LoginForm();
            ShowForm(LoginInstance, currentForm);
        }

        public static void ExitApplication()
        {
            Application.Exit();
        }
    }
}