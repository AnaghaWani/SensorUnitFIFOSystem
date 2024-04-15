using ReelManagement.Forms;

namespace ReelManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            /*string user_nm = "username";
            string pwd = "pass";
            string rle = "Admin";
            Application.Run(new mainmenu(user_nm,rle,pwd));*/

            Application.Run(new login());
        }
    }
}
