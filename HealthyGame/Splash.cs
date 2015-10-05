using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyGame
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                btnStart.Visible = true;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
