using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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
        public double p1Average;
        public double p2Average;
        public gameOf01()
        {
            InitializeComponent();
            p1round = 1;
            p2round = 1;
            p1roundscore = 0;
            p2roundscore = 0;
            p1remaining = Program.game01StartScore;
            p2remaining = Program.game01StartScore;
            p1dartsthrown = 0;
            p2dartsthrown = 0;
            p1501lbl.Text = Program.game01StartScore.ToString();
            p2501lbl.Text = Program.game01StartScore.ToString();
            playAgainbtn.Visible = false;

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
                p2throwbox.Focus();
            }
            else
            {
                p1throwbox.Focus();
            }
            outsP1lbl.Text = Darts_Outs.OutsLibrary.score(p1remaining);
            if (p1remaining == 0)
            {
                addthrowp1btn.Enabled = false;
                addthrowp2btn.Enabled = false;
                playAgainbtn.Visible = true;
            }
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
                p1throwbox.Focus();
            }
            else
            {
                p2throwbox.Focus();
            }
            outsP2lbl.Text = Darts_Outs.OutsLibrary.score(p2remaining);
            if (p2remaining == 0)
            {
                addthrowp1btn.Enabled = false;
                addthrowp2btn.Enabled = false;
                playAgainbtn.Visible = true;
            }
        }

        private void addthrowp1btn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void p1throwbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                addthrowp1btn.PerformClick();
                e.Handled = true;
            }
        }

        private void p2throwbox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void p2throwbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                addthrowp2btn.PerformClick();
                e.Handled = true;
            }

        }

        private void playAgainbtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create a new instance of the form
            gameOf01 g01 = new gameOf01();
            g01.Show();
            g01.Activate();
        }
    }
}
