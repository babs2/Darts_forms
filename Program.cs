namespace Darts_forms
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
            Application.Run(new Game_select());
        }

        public static void cricketGame(bool pointCap, bool lowball)
        {

        }

        public static void game01(string checkIn, string checkOut, bool splitBull)
        {

        }

        public static void training(bool steel, bool soft)
        {

        }
    }
}