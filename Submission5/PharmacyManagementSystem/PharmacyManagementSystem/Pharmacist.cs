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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashbrd_Click(object sender, EventArgs e)
        {
            uC_Pharma_DashBrd1.Visible = true;
            uC_Pharma_DashBrd1.BringToFront();
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_Pharma_DashBrd1.Visible = false;
            uC_Pharma_AddMed1.Visible = false;
            uC_Pharma_ViewMed1.Visible = false;
            uC_Pharma_UpdateMed1.Visible = false;
            uC_Pharma_ValMed2.Visible = false;
            uC_Pharma_SellMed1.Visible = false;
            btnDashbrd.PerformClick();
        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            uC_Pharma_AddMed1.Visible = true;
            uC_Pharma_AddMed1.BringToFront();
        }

        private void btnViewMed_Click(object sender, EventArgs e)
        {
            uC_Pharma_ViewMed1.Visible = true;
            uC_Pharma_ViewMed1.BringToFront();
        }

        private void btnModMed_Click(object sender, EventArgs e)
        {
            uC_Pharma_UpdateMed1.Visible = true;
            uC_Pharma_UpdateMed1.BringToFront();
        }

        private void btnMedVal_Click(object sender, EventArgs e)
        {
            uC_Pharma_ValMed2.Visible = true;
            uC_Pharma_ValMed2.BringToFront();
        }

        
        private void btnSellMed_Click(object sender, EventArgs e)
        {
            uC_Pharma_SellMed1.Visible = true;
            uC_Pharma_SellMed1.BringToFront();
        }

        
    }
}
