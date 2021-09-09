using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtUsername.Text == "root" && txtPassword.Text == "root")
                {
                    Administrator am = new Administrator();
                    am.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where username = '" + txtUsername.Text + "' and passwrd= '" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if(ds.Tables[0].Rows.Count!=0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if(role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role=="Pharmacist")
                    {
                        Pharmacist2 pharm = new Pharmacist2();
                        pharm.Show();
                        this.Hide();
                    }
                    else if (role == "Customer")
                    {
                        Customer customer = new Customer();
                        customer.Show();
                        this.Hide();
                    }
                    else if (role == "System User")
                    {
                        SystemUser sysuser = new SystemUser();
                        sysuser.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Incorrect Username OR Password","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //if (txtUsername.Text == "Pharmacist1" && txtPassword.Text == "password")
            //{
            //    Administrator am = new Administrator();
            //    am.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        
    }
}
