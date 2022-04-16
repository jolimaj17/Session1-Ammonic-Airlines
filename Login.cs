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
    public partial class Login : Form
    {

        SQLConnect R = new SQLConnect();
        String sql;

        public int attempt = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logins();
        }
        //login code
        private void Logins()
        {
            string fullname, pass, uname, role;


            sql = @"  Select Email,Password,RoleID,FirstName,LastName from Users
                 where Email='" + txtEmail.Text +
                "'and Password='" + txtPass.Text + "'and Active=1";
            R.DisplaySingle(sql);
            fullname = R.getf4() + " " + R.getf5();
            pass = R.getf2();
            uname = R.getf1();
            role = R.getf3();


            validation();

            if (attempt == 3)
            {
                
                this.Hide();
                Attempt a = new Attempt();
                a.Show();
            }
            else if (txtEmail.Text!=uname && txtPass.Text!=pass)
            {
                MessageBox.Show("Incorrect  username or password!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attempt = attempt + 1;
            }
            else
            {
                if (role == "1")
                {
                    Admin a = new Admin(txtEmail.Text);
                    MessageBox.Show("Welcome!!"+ " "+fullname.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    a.Show();
                }
                else if (role == "2")
                {

                    string date, logout, reasons;
                    sql = @"Select Date,Login,cast(Logout as varchar),Reasons from Logs 
                    inner join Users on Users.ID = Logs.UserID where Logout='00:00:00.0000000' and Reasons<>''";
                    R.DisplaySingle(sql);
                    date = R.getf1();
                    logout = R.getf3();
                    if (R.getf1() == date && R.getf2()=="")
                    {
                        insert();
                        Users a = new Users(txtEmail.Text);
                        a.Show();
                        this.Hide();
                    }
                    else if (R.getf3() != logout)
                    {
                        NologoutDetected a = new NologoutDetected(txtEmail.Text);
                        a.Show();
                        this.Hide();
                    }
                }
            }
        }

        //insert firstime
        private void insert()
        {

            sql = "Select ID from Users where Email='" + txtEmail.Text + "'";
            R.DisplaySingle(sql);
            sql = @"insert into Logs Values('" + R.getf1() + "','" + DateTime.Now.ToString("yyyyMMdd") + "','" + DateTime.Now.ToString("hh:mm:ss") + "','','','')";
            R.Modify(sql);
        }

        //validation code
        private void validation()
        {
            if(txtEmail.Text=="" && txtPass.Text == "")
            {
                MessageBox.Show("Please enter username and password!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter username !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( txtPass.Text == "")
            {
                MessageBox.Show("Please enter password!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
