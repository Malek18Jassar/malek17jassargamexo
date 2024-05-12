using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Game_xo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btp1_Click(object sender, EventArgs e)
        {
            play1 play = new play1();
            play.Show();
          this.Hide();
        }

        private void btp2_Click(object sender, EventArgs e)
        {
            play2 play = new play2();
            play.Show();
          this.Hide();
        }

        private void ptclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
