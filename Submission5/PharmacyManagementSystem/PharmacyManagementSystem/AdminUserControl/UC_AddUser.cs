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
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        string query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string role = txtRole.Text;
            string names = txtName.Text;
            string dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string passwrd = txtPasswrd.Text;

            try
            {
                query = "INSERT INTO users (userRole, names, dob, mobile, email, username, passwrd) values ('"+role+ "', '"+names+"', '"+dob+"', '"+mobile+"', '"+email+"', '"+username+ "', '"+passwrd+"')";
                fn.setData(query, "Sign Up Successful.");
            }
            catch(Exception)
            {
                MessageBox.Show("Username already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtName.Clear();
            txtDOB.ResetText();
            txtMobile.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPasswrd.Clear();
            txtRole.SelectedIndex = -1;
        }

        
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM users WHERE username = '"+txtUsername.Text+"'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.ImageLocation = @"G:\My Drive\C# Pharmacy Management System.rar (Unzipped Files)\Pharmacy Management System in C#\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"G:\My Drive\C# Pharmacy Management System.rar (Unzipped Files)\Pharmacy Management System in C#\no.png";
            }
        }

        
    }
}
