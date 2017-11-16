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
        Random r = new Random();
    
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            k = k + 1;
            label1.Text = k.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(r.Next(100, this.Width - pictureBox1.Width), r.Next(100, this.Height - pictureBox1.Width));
            pictureBox1.Location = p1;
            p = p + 1;
            if (p == 60)
            {
                
                timer1.Enabled = false;
                pictureBox1.Visible = false;
                MessageBox.Show("The End");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p = 0;
            pictureBox1.Visible = true;
            timer1.Enabled = true;
            
        }
    }
}
