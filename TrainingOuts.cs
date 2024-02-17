using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darts_forms
{
    public partial class TrainingOuts : Form
    {
        public static int minOut;
        public static int maxOut;
        public static int runningScore = 0;
        public static int darts = 0;
        public static int outTesting;
        public Random rnd = new Random();

        public TrainingOuts()
        {
            InitializeComponent();            
        }

        private void dblOutCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void masterOutCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        // the go button... cause I'm dumb
        private void button49_Click(object sender, EventArgs e)
        {
            //minOutBox & maxOutBox
            minOut = Convert.ToInt32(minOutBox.Text);
            maxOut = Convert.ToInt32(maxOutBox.Text);
            outTesting = rnd.Next(minOut,maxOut);
            testingOutlbl.Text = outTesting.ToString();
            darts = 0;
            actualOuts.Text = "";
            runningScore = 0;

        }

        private void single1_Click(object sender, EventArgs e)
        {
            runningScore += 1;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double1_Click(object sender, EventArgs e)
        {
            runningScore += 2;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void tripple1_Click(object sender, EventArgs e)
        {
            runningScore += 3;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single2_Click(object sender, EventArgs e)
        {
            runningScore += 2;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double2_Click(object sender, EventArgs e)
        {
            runningScore += 4;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void tripple2_Click(object sender, EventArgs e)
        {
            runningScore += 6;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single3_Click(object sender, EventArgs e)
        {
            runningScore += 3;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double3_Click(object sender, EventArgs e)
        {
            runningScore += 6;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void tripple3_Click(object sender, EventArgs e)
        {
            runningScore += 9;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single4_Click(object sender, EventArgs e)
        {
            runningScore += 4;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double4_Click(object sender, EventArgs e)
        {
            runningScore += 8;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void tripple4_Click(object sender, EventArgs e)
        {
            runningScore += 12;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single5_Click(object sender, EventArgs e)
        {
            runningScore += 5;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double5_Click(object sender, EventArgs e)
        {
            runningScore += 10;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void tripple5_Click(object sender, EventArgs e)
        {
            runningScore += 15;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single6_Click(object sender, EventArgs e)
        {
            runningScore += 6;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double6_Click(object sender, EventArgs e)
        {
            runningScore += 12;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple6_Click(object sender, EventArgs e)
        {
            runningScore += 18;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single7_Click(object sender, EventArgs e)
        {
            runningScore += 7;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double7_Click(object sender, EventArgs e)
        {
            runningScore += 14;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple7_Click(object sender, EventArgs e)
        {
            runningScore += 21;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single8_Click(object sender, EventArgs e)
        {
            runningScore += 8;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double8_Click(object sender, EventArgs e)
        {
            runningScore += 16;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple8_Click(object sender, EventArgs e)
        {
            runningScore += 24;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single9_Click(object sender, EventArgs e)
        {
            runningScore += 9;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double9_Click(object sender, EventArgs e)
        {
            runningScore += 18;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple9_Click(object sender, EventArgs e)
        {
            runningScore += 27;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single10_Click(object sender, EventArgs e)
        {
            runningScore += 10;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double10_Click(object sender, EventArgs e)
        {
            runningScore += 20;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple10_Click(object sender, EventArgs e)
        {
            runningScore += 30;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single11_Click(object sender, EventArgs e)
        {
            runningScore += 11;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double11_Click(object sender, EventArgs e)
        {
            runningScore += 22;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple11_Click(object sender, EventArgs e)
        {
            runningScore += 33;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single12_Click(object sender, EventArgs e)
        {
            runningScore += 12;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double12_Click(object sender, EventArgs e)
        {
            runningScore += 24;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple12_Click(object sender, EventArgs e)
        {
            runningScore += 36;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single13_Click(object sender, EventArgs e)
        {
            runningScore += 13;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double13_Click(object sender, EventArgs e)
        {
            runningScore += 26;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple13_Click(object sender, EventArgs e)
        {
            runningScore += 39;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single14_Click(object sender, EventArgs e)
        {
            runningScore += 14;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double14_Click(object sender, EventArgs e)
        {
            runningScore += 28;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple14_Click(object sender, EventArgs e)
        {
            runningScore += 42;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single15_Click(object sender, EventArgs e)
        {
            runningScore += 15;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double15_Click(object sender, EventArgs e)
        {
            runningScore += 30;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple15_Click(object sender, EventArgs e)
        {
            runningScore += 45;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single16_Click(object sender, EventArgs e)
        {
            runningScore += 16;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double16_Click(object sender, EventArgs e)
        {
            runningScore += 32;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple16_Click(object sender, EventArgs e)
        {
            runningScore += 48;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single17_Click(object sender, EventArgs e)
        {
            runningScore += 17;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double17_Click(object sender, EventArgs e)
        {
            runningScore += 34;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple17_Click(object sender, EventArgs e)
        {
            runningScore += 51;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single18_Click(object sender, EventArgs e)
        {
            runningScore += 18;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double18_Click(object sender, EventArgs e)
        {
            runningScore += 36;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple18_Click(object sender, EventArgs e)
        {
            runningScore += 54;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single19_Click(object sender, EventArgs e)
        {
            runningScore += 19;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double19_Click(object sender, EventArgs e)
        {
            runningScore += 38;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple19_Click(object sender, EventArgs e)
        {
            runningScore += 57;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void single20_Click(object sender, EventArgs e)
        {
            runningScore += 20;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void double20_Click(object sender, EventArgs e)
        {
            runningScore += 40;
            darts++;
            // MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void triple20_Click(object sender, EventArgs e)
        {
            runningScore += 60;
            darts++;
            // MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void singleBull_Click(object sender, EventArgs e)
        {
            runningScore += 25;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
                MessageBox.Show("Running: " + runningScore.ToString() + " darts: " + darts.ToString());
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }

        private void doubleBull_Click(object sender, EventArgs e)
        {
            runningScore += 50;
            darts++;
            if ((darts == 3) && (runningScore != outTesting))
            {
                actualOuts.Text = Darts_Outs.OutsLibrary.score(outTesting);
            }
            if ((darts <= 3) && (runningScore == outTesting))
            {
                actualOuts.Text = "Yes!! ";
            }
        }
    }
}
