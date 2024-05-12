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
    public partial class play1 : Form
    {
        public play1()
        {
            InitializeComponent();
        }

        bool t = true;
        int count = 0;
        private void plx_Click(object sender, EventArgs e)
        {
            
       


            Button B = (Button)sender;
            if (t)
                B.Text = "X";
              
            else
                B.Text = "O";
          

            t = !t;

            B.Enabled = false;
            count++;
            game();
        }
       
        private void game()
        {
            bool i = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {
                i = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled)) 
            { i = true; }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
            { i = true; }



            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            { i = true; }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            { i = true; }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            { i = true; }

            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            { i = true; }
            else if ((a3.Text == b2.Text) && (b3.Text == c1.Text) && (!a3.Enabled))
            { i = true; }
            if (i)
            {
                string s;
                if (t)
                {
                    int n = Convert.ToInt32(x.Text);
                    n++;
                    x.Text = n.ToString();
                    s=plo.Text.ToString();
                     
                 
                    
                    
                }
                else
                {
                    int n = Convert.ToInt32(o.Text);
                    n++;
                    o.Text = n.ToString();
                    s = plx.Text.ToString();
                   
                }
                MessageBox.Show("win"+s);
                remove();
                count = 0;
          
            }

            if (count == 9)
            {
                MessageBox.Show("draw");
                remove();
                count = 0;
                remove();

            }
        }
        private void remove()
        {
            foreach (Control c in panel7.Controls)
            {
                try
                {
                    Button f = (Button)c;
                    f.Enabled = true;
                    f.Text = "  ";
                }
                catch { }
            }
        }
        
        
        
       





        

       


        private void btp1_Click_1(object sender, EventArgs e)
        {
            remove();
          
        }

        private void ptclose_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

        private void play1_Load(object sender, EventArgs e)
        {

        }

      


      


        

       

  
    }
}
