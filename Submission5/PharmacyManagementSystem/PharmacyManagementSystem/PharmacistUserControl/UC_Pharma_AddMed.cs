using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.PharmacistUserControl
{
    public partial class UC_Pharma_AddMed : UserControl
    {
        function fn = new function();
        string query;


        public UC_Pharma_AddMed()
        {
            InitializeComponent();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedNDC.Text != "" && txtMedName.Text != "" && txtMedDose.Text != "" && txtMedLOT.Text != "" && txtQty.Text != "" && txtPriceUnit.Text != "")
            {
                string medNDC = txtMedNDC.Text;
                string medName = txtMedName.Text;
                string medDose = txtMedDose.Text;
                string medLOT = txtMedLOT.Text;
                string mDate = txtMfgr.Text;
                string eDate = txtExpr.Text;
                Int64 quantity = Int64.Parse(txtQty.Text);
                float unitPrice = float.Parse(txtPriceUnit.Text);

                query = "insert into MedicineList (medNDC, medName, medDose, medLOT, mDate, eDate, quantity, unitPrice) values ('"+ medNDC + "', '"+ medName + "', '"+ medDose + "', '"+ medLOT + "', '"+ mDate + "', '"+ eDate + "', '"+ quantity + "', '"+ unitPrice + "')";
                fn.setData(query, "Medicine successfully added.");

            }
            else
            {
                MessageBox.Show("Enter Medicine Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lblUnitPrc_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMedNDC.Clear();
            txtMedName.Clear();
            txtMedDose.Clear();
            txtMedLOT.Clear();
            txtMfgr.ResetText();
            txtExpr.ResetText();
            txtQty.Clear();
            txtPriceUnit.Clear();
        }

        
    }
}
