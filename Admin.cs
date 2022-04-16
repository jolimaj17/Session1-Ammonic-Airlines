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
    public partial class Admin : Form
    {

        SQLConnect R = new SQLConnect();
        String sql;
        String current,o;
        public Admin(string email)
        {
            InitializeComponent();
            current = email.ToString();
            
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            //enable code
            if (Convert.ToBoolean(AdminDG.Rows[AdminDG.CurrentRow.Index].Cells["Active"].Value.ToString())== true)
            {
                sql = "Update Users set Active=0 where Email='" + AdminDG.Rows[AdminDG.CurrentRow.Index].Cells["Active"].Value+ "'";
                R.Modify(sql);
                MessageBox.Show("The users is temporarily disable!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                sql = "Update Users set Active=1 where Email='" + AdminDG.Rows[AdminDG.CurrentRow.Index].Cells["Active"].Value + "'";
                R.Modify(sql);
                MessageBox.Show("The users is now enable!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            EditUser a = new EditUser(current);
            a.dv = AdminDG.Rows[AdminDG.CurrentRow.Index];
            a.Show();
            this.Hide();
        }

        private void AddUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser a = new AddUser(current);
            a.Show();
            this.Hide();
        }

        private void Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
        //code for displaying
        private void Admin_Load(object sender, EventArgs e)
        {
            sql = @"  Select Users.FirstName as [Name], Users.LastName as [LastName], 
            DATEDIFF(Year, Users.Birthdate,CURRENT_TIMESTAMP)as [Age],
            Roles.Title as [User Role],  Users.Email as [Email Address], Offices.Title as[Office],Active
            from Users
            inner join Roles on Users.RoleID=Roles.ID
            inner join Offices on Users.OfficeID=Offices.ID where Email<>'"+current.ToString()+"'";
            AdminDG.DataSource = R.MultipleData(sql).Tables["tbl"];
            this.AdminDG.Columns["Active"].Visible = false;
            color();
        }
        //code for sort
        private void cmbOffice_SelectedIndexChanged(object sender, EventArgs e)
        {
            offices();
            sql = @"  Select Users.FirstName as [Name], Users.LastName as [LastName], 
            DATEDIFF(Year, Users.Birthdate,CURRENT_TIMESTAMP)as [Age],
            Roles.Title as [User Role],  Users.Email as [Email Address], Offices.Title as[Office],Active
            from Users
            inner join Roles on Users.RoleID=Roles.ID
            inner join Offices on Users.OfficeID=Offices.ID where Email<>'" + current.ToString() + "' and OfficeID='" + o+"'";
            AdminDG.DataSource = R.MultipleData(sql).Tables["tbl"];
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
        //code for color
        private void color()
        {

            if (AdminDG.Rows[AdminDG.CurrentRow.Index].Cells["User Role"].Value.ToString() == "Administrator")
            {
                AdminDG.DefaultCellStyle.BackColor = Color.FromArgb(247, 148, 032);
            }
            else
            {
                AdminDG.DefaultCellStyle.BackColor = Color.FromArgb(000, 160, 187);
            }
            
            

        }

        private void AdminDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
