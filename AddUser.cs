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
    public partial class AddUser : Form
    {

        SQLConnect R = new SQLConnect();
        String sql;
        String current, o;
        public AddUser(string email)
        {
            InitializeComponent();
            current = email.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //code for adding
            offices();
            sql = @"insert into Users values((Select MAX(ID) from Users)+1,2,
                '" + txtEmail.Text + "','"
                + txtPass.Text + "','"
                + txtfname.Text + "','"
                + txtLname.Text+ "','"
                + o.ToString()+"','"
                + bdate.Value.ToString() +
                 "',1)";
            R.Modify(sql);
            MessageBox.Show("Users successfully added!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Admin a = new Admin(current);
            a.Show();
            this.Hide();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(current);
            a.Show();
            this.Hide();
        }

        //code for offices number
        private void offices()
        {
            if (cmbOffice.SelectedIndex == 0)
            {
                o = "1";
            }
            else if (cmbOffice.SelectedIndex == 1)
            {
                o = "3";
            }
            else if (cmbOffice.SelectedIndex == 2)
            {
                o = "4";
            }
            else if (cmbOffice.SelectedIndex == 3)
            {
                o = "5";
            }
            else if (cmbOffice.SelectedIndex == 4)
            {
                o = "6";
            }
        }
    }
}
