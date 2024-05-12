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
    public partial class play2 : Form
    {
        public enum playar
        {
            X, O
        }
        playar corplayar;
        Random random = new Random();
        int count_screen = 0;
        int count_computer = 0;
        List<Button> buttons;




        public play2()
        {
            InitializeComponent();
            restartgame();
        }
        private void restartgame()
        {
            buttons = new List<Button>() { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            foreach (Button b in buttons)
            {
                b.Enabled = true;
                b.Text = " ";
            }

        }
        private void checkgame()
        {
            if (A1.Text == "X" && A2.Text == "X" && A3.Text == "X"
            || B1.Text == "X" && B2.Text == "X" && B3.Text == "X"
                || C1.Text == "X" && C2.Text == "X" && C3.Text == "X"
                    || A1.Text == "X" && B1.Text == "X" && C1.Text == "X"
 || A2.Text == "X" && B2.Text == "X" && C2.Text == "X"
  || A3.Text == "X" && B3.Text == "X" && C3.Text == "X"
   || A1.Text == "X" && B2.Text == "X" && C3.Text == "X"
   || A3.Text == "X" && B2.Text == "X" && C1.Text == "X")
            {
                timer.Stop();
                MessageBox.Show("win" + mysc.Text);
                count_screen++;
                scr.Text = count_screen.ToString();
                restartgame();
            }
            else if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O"
            || B1.Text == "O" && B2.Text == "O" && B3.Text == "O"
                || C1.Text == "O" && C2.Text == "O" && C3.Text == "O"
                    || A1.Text == "O" && B1.Text == "O" && C1.Text == "O"
 || A2.Text == "O" && B2.Text == "O" && C2.Text == "O"
  || A3.Text == "O" && B3.Text == "O" && C3.Text == "O"
   || A1.Text == "O" && B2.Text == "O" && C3.Text == "O"
   || A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
            {
                timer.Stop();
                MessageBox.Show("win" + myco.Text);
                count_computer++;
                com.Text = count_computer.ToString();
                restartgame();

            }

        }




        private void play2_Load(object sender, EventArgs e)
        {
            restartgame();

        }



        private void cpumove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                corplayar = playar.O;
                buttons[index].Text = corplayar.ToString();
                buttons.RemoveAt(index);
                checkgame();
                timer.Stop();
            }


        }



        private void A1_Click(object sender, EventArgs e)
        {
            var buttone = (Button)sender;
            corplayar = playar.X;
            buttone.Text = corplayar.ToString();
            buttone.Enabled = false;
            buttons.Remove(buttone);
            checkgame();
            timer.Start();
        }

        private void btp1_Click(object sender, EventArgs e)
        {
            restartgame();
        }
        private void ptclose_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}

