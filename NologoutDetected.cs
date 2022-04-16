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

    public partial class NologoutDetected : Form
    {
        SQLConnect R = new SQLConnect();
        String sql,current;
        public NologoutDetected(string email)
        {
            InitializeComponent();
            current = email.ToString();
        }

        private void NologoutDetected_Load(object sender, EventArgs e)
        {
            
            sql = "Select ID from Users where Email='" + current + "'";
            R.DisplaySingle(sql);
          
            sql = @"Select Count(Reasons) from Logs where UserID='" + R.getf1() + "'";
            R.DisplaySingle(sql);

            sql = @"Select Date,Login from Logs where UserID='" + R.getf1() + "' and Logout='00:00:00.0000000'";
            R.DisplaySingle(sql);
            mess.Text = "No logout detected for your last login on" + " " + R.getf1() + " " + "at" + R.getf2();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (soft.Checked == true)
            {
                textBox1.Text = soft.Text;
            }
            else if (system.Checked == true)
            {
                textBox1.Text = system.Text;
            }

            sql = @"Update Logs set Reasons='" + textBox1.Text + "'where  Logout='00:00:00.0000000'";
            R.Modify(sql);
            Users a = new Users(current);
            a.Show();
            this.Hide();
        }
    }
}
