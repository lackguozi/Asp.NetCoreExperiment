using AutoUpdaterDotNET;

namespace SquirrelDemo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AutoUpdater.Start("https://example.com/your-app/update.xml");
            AutoUpdater.UpdateMode = Mode.ForcedDownload;
            AutoUpdater.CheckForUpdateEvent += AutoUpdater_CheckForUpdateEvent;


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static void AutoUpdater_CheckForUpdateEvent(UpdateInfoEventArgs args)
        {
           
        }
    }
}