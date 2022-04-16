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
    public partial class Users : Form
    {

        SQLConnect R = new SQLConnect();
        String sql;
        String current, o;
        public Users(string email)
        {
            InitializeComponent();
            current = email.ToString();
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sql = @"Select ID from Users where Email='" + current.ToString() + "'";
            R.DisplaySingle(sql);
            sql = "Update Logs set Logout='" + DateTime.Now.ToString("HH:mm:ss") + "'where UserID='" + R.getf1() + "'and Logout<>'00:00:00.0000000' and Reasons<>System Crash or Reasons<>Software Crash ";
            this.Close();

        }

        private void Users_Load(object sender, EventArgs e)
        {

            sql = "Select ID from Users where Email='" + current + "'";
            R.DisplaySingle(sql);

            sql = @"Select Count(Reasons) from Logs where UserID='" + R.getf1() + "'";
            R.DisplaySingle(sql);
            lblCrash.Text = "Number of Crash"+" "+R.getf1();
            lblTime.Text = "Number of Time spent on the system";
            sql = @"Select FirstName from Users where Email='" + current.ToString() + "'";
            R.DisplaySingle(sql);

            lblHi.Text = "Hi!" + " " + R.getf1() + ", Welcome to AMONIC Airlines.";
            sql = @"Select ID from Users where Email='" + current.ToString() + "'";
            R.DisplaySingle(sql);


            sql = @"Select Date, Login as [Login Time],
                case when cast(Logout as varchar) = '00:00:00.0000000' then '***'
	                else cast(Logout as varchar) end as [Logout Time], TimeSpent, Reasons

                     from Logs where UserID='"+R.getf1()+"'";
            UserDG.DataSource = R.MultipleData(sql).Tables["tbl"];
        }
    }
}
