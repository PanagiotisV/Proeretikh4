using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        int p = 0;
        int k = 0;
        Size a = new Size(160, 154);
        Size b = new Size(80, 77);
        Random r = new Random();
        bool op = false;
    
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (op == true)
            {
                k = k + 1;
                label1.Text = k.ToString();
            }
            op = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Point p1 = new Point(r.Next(100, this.Width - pictureBox1.Width), r.Next(100, this.Height - pictureBox1.Width));
            pictureBox1.Location = p1;
            p = p + 1;
            op = true;
            if(comboBox1.Text == "Hard"){
                if (p == 120)
                {

                    timer1.Enabled = false;
                    pictureBox1.Visible = false;
                    p = 0;
                    k = 0;
                    label1.Text = k.ToString();
                    MessageBox.Show("The End");
                }
            }
            else
            {
                if (p == 60)
                {

                    timer1.Enabled = false;
                    pictureBox1.Visible = false;
                    p = 0;
                    k = 0;
                    label1.Text = k.ToString();
                    MessageBox.Show("The End");
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = 0;
            
            if (comboBox1.Text == "Hard")
            {
                timer1.Interval = 500;
                pictureBox1.Size = b;

            }
            else
            {
                timer1.Interval = 1000;
                pictureBox1.Size = a;
            }
            pictureBox1.Visible = true;
            timer1.Enabled = true;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
