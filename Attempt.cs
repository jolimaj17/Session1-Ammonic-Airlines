using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Attempt : Form
    {
        int time = 0;
        public Attempt()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time = time - 1;
                lbltime.Text = time.ToString();
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Login a = new Login();
                a.Show();
            }
        }

        private void Attempt_Load(object sender, EventArgs e)
        {
            time = 10;
            lbltime.Text = time.ToString();
            timer1.Start();
        }
    }
}
