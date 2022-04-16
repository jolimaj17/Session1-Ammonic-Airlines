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
    public partial class EditUser : Form
    {

        SQLConnect R = new SQLConnect();
        String sql;
        String current, o;
        public DataGridViewRow dv;
        public EditUser(string email)
        {
            InitializeComponent();
            current = email.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //code for save

            if (rdUser.Checked == true)
            {
                sql = @"Update Users set RoleID=2 where Email='" + txtEmail.Text + "'";
                R.Modify(sql);
                MessageBox.Show("Roles is successfully update!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin a = new Admin(current);
                a.Show();
                this.Hide();
            }
            else if (rAdmin.Checked == true)
            {
                sql = @"Update Users set RoleID=1 where Email='" + txtEmail.Text+ "'";
                R.Modify(sql);
                MessageBox.Show("Roles is successfully update!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin a = new Admin(current);
                a.Show();
                this.Hide();
            }


        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            txtEmail.Text = dv.Cells[4].Value.ToString();
            txtfname.Text = dv.Cells[0].Value.ToString();
            txtLname.Text = dv.Cells[1].Value.ToString();
            cmbOffice.Text = dv.Cells[5].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //code for cancel
            Admin a = new Admin(current);
            a.Show();
            this.Hide();
        }
    }
}
