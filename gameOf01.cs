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

    public partial class gameOf01 : Form
    {
        public static int p1round;
        public int p2round;
        public int p1roundscore;
        public int p2roundscore;
        public int p1remaining;
        public int p2remaining;
        public int p1dartsthrown;
        public int p2dartsthrown;
        public gameOf01()
        {
            InitializeComponent();
            p1round = 1;
            p2round = 1;
            p1roundscore = 0;
            p2roundscore = 0;
            p1remaining = 501;
            p2remaining = 501;
            p1dartsthrown = 0;
            p2dartsthrown = 0;

            //while ((p1remaining > 0) && (p2remaining > 0))
            //{

            //}
        }

        private void addthrowp1btn_Click(object sender, EventArgs e)
        {
            p1dartsthrown++;
            p1remaining -= Convert.ToInt32(p1throwbox.Text);
            p1501lbl.Text = p1remaining.ToString();
            p1roundscore += Convert.ToInt32(p1throwbox.Text);
            roundScoreP1.Text = p1roundscore.ToString();
            p1throwbox.Text = "";
            if (p1dartsthrown % 3 == 0)
            {
                p1dartsthrown = 0;
                p1round++;
                p2roundscore = 0;
                addthrowp2btn.Enabled = true;
                addthrowp1btn.Enabled = false;
            }
            outsP1lbl.Text = Darts_Outs.OutsLibrary.score(p1remaining);
        }

        private void addthrowp2btn_Click(object sender, EventArgs e)
        {
            p2dartsthrown++;
            p2remaining -= Convert.ToInt32(p2throwbox.Text);
            p2501lbl.Text = p2remaining.ToString();
            p2roundscore += Convert.ToInt32(p2throwbox.Text);
            roundScoreP2.Text = p2roundscore.ToString();
            p2throwbox.Text = "";
            if (p2dartsthrown % 3 == 0)
            {
                p2dartsthrown = 0;
                p2round++;
                p1roundscore = 0;
                addthrowp2btn.Enabled = false;
                addthrowp1btn.Enabled = true;
            }
            outsP2lbl.Text = Darts_Outs.OutsLibrary.score(p2remaining);
        }
    }
}
