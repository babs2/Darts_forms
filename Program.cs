namespace Darts_forms
{
    internal static class Program
    {
        public static int game01StartScore;
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
            MessageBox.Show("Cricket Coming soon");
        }

        public static void game01(string checkIn, string checkOut, bool splitBull)
        {
            //MessageBox.Show("01 game selected");
            gameOf01 g01 = new gameOf01();
            g01.Show();
            g01.Activate();
        }

        public static void training(bool steel, bool soft)
        {
            boardForm dartBoard = new boardForm();
            dartBoard.Show();
            dartBoard.Activate();
            //TrainingOuts training = new TrainingOuts();
            //training.Show();
            //training.Activate();
        }
    }
}