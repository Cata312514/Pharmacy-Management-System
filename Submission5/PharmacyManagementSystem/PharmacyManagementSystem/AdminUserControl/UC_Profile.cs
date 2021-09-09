using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.AdminUserControl
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        string query;

        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { lblUsername.Text = value; }
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from users where username = '"+lblUsername.Text+"'";
            DataSet ds = fn.getData(query);
            txtRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDOB.Text = ds.Tables[0].Rows[0][3].ToString();
            txtMobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtPass.Text = ds.Tables[0].Rows[0][7].ToString();
        }

       
        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string role = txtRole.Text;
            string names = txtName.Text;
            string dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string email = txtEmail.Text;
            string username = lblUsername.Text;
            string passwrd = txtPass.Text;

            query = "update users set userRole = '"+role+"', names = '"+names+"' , dob = '"+dob+"', mobile = '"+mobile+"', email = '"+email+"', username = '"+username+"', passwrd= '"+passwrd+"'";
            fn.setData(query, "Profile update successful.");
        }
    }
}
