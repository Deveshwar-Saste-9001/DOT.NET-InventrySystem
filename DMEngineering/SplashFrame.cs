using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMEngineering
{
    public partial class SplashFrame : Form
    {
        public SplashFrame()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void SplashFrame_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            bunifuProgressBar1.Value = startpoint;
            if (bunifuProgressBar1.Value == 100)
            {
                bunifuProgressBar1.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();

            }


        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
