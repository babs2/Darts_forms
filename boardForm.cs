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
    public partial class boardForm : Form
    {
        public boardForm()
        {
            InitializeComponent();
        }

        private void boardForm_Load(object sender, EventArgs e)
        {

        }

        private void double20btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("double 20 Clicked");

        }

        private void double1btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("double 1 Clicked");
        }

        private void trip20btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("triple 20 Clicked");
        }

        // this is the upper single 20 segment
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("single 20 Clicked");
        }

        private void up_single_1btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("single 1 Clicked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("25 clicked");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("50 clicked");
        }
    }
}
