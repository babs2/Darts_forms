using Darts_Outs;

namespace Darts_forms
{
    public partial class Game_select : Form
    {
        //01 global variables
        public static string checkIn = "open";
        public static string checkOut = "open";
        public static bool bull;

        //cricket global variables
        public static bool pointCap;
        public static bool lowball;

        //training global
        public static bool steel;
        public static bool soft;

        public Game_select()
        {
            InitializeComponent();
        }

        private void CricketLowBallBox_CheckedChanged(object sender, EventArgs e)
        {
            // cricket game - clear out 01 options
            checkBox01.Checked = false;
            DoubleInChkBox.Checked = false;
            doubleOutChkBox.Checked = false;
            MasterInChkBox.Checked = false;
            MasterOutChkBox.Checked = false;
            OpenOutChkBox.Checked = false;
            OpenInChkBox.Checked = false;
            splitBullChkBoc.Checked = false;

            // cricket game - clear out trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // set the game selected to be true
            checkBox_cricket.Checked = true;

            if (CricketLowBallBox.Checked)
            {
                lowball = true;
            }
            else { lowball = false; }
        }

        private void checkBox01_CheckedChanged(object sender, EventArgs e)
        {
            // 01 options - clear out trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // 01 options - clear out cricket
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;
        }

        private void checkBox_cricket_CheckedChanged(object sender, EventArgs e)
        {
            // cricket checked - clear out 01 game options
            checkBox01.Checked = false;
            DoubleInChkBox.Checked = false;
            doubleOutChkBox.Checked = false;
            MasterInChkBox.Checked = false;
            MasterOutChkBox.Checked = false;
            splitBullChkBoc.Checked = false;

            // clear out trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;
        }

        private void DoubleInChkBox_CheckedChanged(object sender, EventArgs e)
        {
            // 01 options - clear out trainer options
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // 01 options - clear out cricket options
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            // Double in - clear out other check in options
            MasterInChkBox.Checked = false;
            OpenInChkBox.Checked = false;

            // set the game selected to be true
            checkBox01.Checked = true;
            checkIn = "double";
        }

        private void cricketPointsCap_CheckedChanged(object sender, EventArgs e)
        {
            // cricket options - clear out 01 game options
            checkBox01.Checked = false;
            DoubleInChkBox.Checked = false;
            doubleOutChkBox.Checked = false;
            MasterInChkBox.Checked = false;
            MasterOutChkBox.Checked = false;
            splitBullChkBoc.Checked = false;
            OpenOutChkBox.Checked = false;
            OpenInChkBox.Checked = false;

            // cricket - clear out trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // set the game selected to be true
            checkBox_cricket.Checked = true;

            if (cricketPointsCap.Checked)
            {
                pointCap = true;
            }
            else { pointCap = false; }
        }

        private void doubleOutChkBox_CheckedChanged(object sender, EventArgs e)
        {
            // 01 options - clear out cricket options
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            // 01 options - clear out the trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // double out so clear out the other check out options
            MasterOutChkBox.Checked = false;
            OpenOutChkBox.Checked = false;

            // set the game selected to be true
            checkBox01.Checked = true;

            if (doubleOutChkBox.Checked)
            {
                checkOut = "double";
            }

        }

        private void MasterInChkBox_CheckedChanged(object sender, EventArgs e)
        {
            // 01 options - clear out cricket options
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            // 01 options - clear out the trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // clear the other check in options
            DoubleInChkBox.Checked = false;
            OpenInChkBox.Checked = false;

            // set the game selected to be true
            checkBox01.Checked = true;

            if (MasterInChkBox.Checked)
            {
                checkIn = "master";
            }

        }

        private void MasterOutChkBox_CheckedChanged(object sender, EventArgs e)
        {
            // 01 options - clear out cricket options
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            //01 options - clear out the trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // clear out the other outs options
            doubleOutChkBox.Checked = false;
            OpenOutChkBox.Checked = false;

            // set the game selected to be true
            checkBox01.Checked = true;

            if (MasterOutChkBox.Checked)
            {
                checkOut = "master";
            }
        }

        private void splitBullChkBoc_CheckedChanged(object sender, EventArgs e)
        {
            // 01 options - clear out cricket options and training
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            //01 options - clear out the trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // set the game selected to be true
            checkBox01.Checked = true;

            if (splitBullChkBoc.Checked)
            {
                bull = true;
            }
            else { bull = false; }
        }

        private void OutsTrainer_CheckedChanged(object sender, EventArgs e)
        {
            // training - clear 01
            checkBox01.Checked = false;
            DoubleInChkBox.Checked = false;
            doubleOutChkBox.Checked = false;
            MasterInChkBox.Checked = false;
            MasterOutChkBox.Checked = false;
            splitBullChkBoc.Checked = false;
            OpenInChkBox.Checked = false;
            OpenOutChkBox.Checked = false;

            // training - clear out cricket game options
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            // training - clear out other training options
            softTipOuts.Checked = false;
            steel = true;
            soft = false;
        }

        private void softTipOuts_CheckedChanged(object sender, EventArgs e)
        {
            // training - clear 01
            checkBox01.Checked = false;
            DoubleInChkBox.Checked = false;
            doubleOutChkBox.Checked = false;
            MasterInChkBox.Checked = false;
            MasterOutChkBox.Checked = false;
            OpenInChkBox.Checked = false;
            OpenOutChkBox.Checked = false;
            splitBullChkBoc.Checked = false;

            // training - clear cricket games
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            // training but clear the other training out
            OutsTrainer.Checked = false;

            soft = true;
            steel = false;
        }

        private void game_selectGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void OpenInChkBox_CheckedChanged(object sender, EventArgs e)
        {
            // 01 options - clear out cricket options
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            //01 option - clear trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            // open in - so uncheck the other options
            DoubleInChkBox.Checked = false;
            MasterInChkBox.Checked = false;

            // set the game selected to be true
            checkBox01.Checked = true;

            if (OpenInChkBox.Checked)
            {
                checkIn = "open";
            }

        }

        private void OpenOutChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //01 options - clear out trainer
            OutsTrainer.Checked = false;
            softTipOuts.Checked = false;

            //01 options - clear cricket
            cricketPointsCap.Checked = false;
            CricketLowBallBox.Checked = false;
            checkBox_cricket.Checked = false;

            //01 game open out - clear out other check out options
            doubleOutChkBox.Checked = false;
            MasterOutChkBox.Checked = false;

            // set the game selected to be true
            checkBox01.Checked = true;

            if (OpenOutChkBox.Checked)
            {
                checkOut = "open";
            }
        }

        private void beginButton_Click(object sender, EventArgs e)
        {

            label1.Text = "checkIn: " + checkIn + " checkout: " + checkOut + " splitBull: " + bull;
            label2.Text = "pointcap: " + pointCap + " lowball: " + lowball + " steel outs: " + steel + " soft tip: " + soft;
            if (checkBox01.Checked)
            {
                bool isNum = int.TryParse(gameOf01Startbox.Text, out Program.game01StartScore);
                if (!isNum) { Program.game01StartScore = 501; }
                Program.game01(checkIn, checkOut, bull);                 
            }
            //if (checkBox_cricket.Checked)
            //{
            //    Program.cricketGame(pointCap, lowball);
            //}
            //if (softTipOuts.Checked)
            //{
            //    Program.training(false, true);
            //}
            if (OutsTrainer.Checked)
            {
                Program.training(true, false);
            }         

        }
    }
}