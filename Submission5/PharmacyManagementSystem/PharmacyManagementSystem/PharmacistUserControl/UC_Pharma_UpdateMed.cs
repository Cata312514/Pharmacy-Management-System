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
    public partial class UC_Pharma_UpdateMed : UserControl
    {
        function fn = new function();
        string query;

        public UC_Pharma_UpdateMed()
        {
            InitializeComponent();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtMedNDC.Text != "")
            {
                query = "select * from MedicineList where medNDC = '" + txtMedNDC.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedNDC.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtMedDose.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMedLOT.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMfgr.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtExpr.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtAvailQty.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtPriceUnit.Text = ds.Tables[0].Rows[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("Medicine with NDC number " + txtMedNDC + " does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }
        

        private void clearAll()
        {
            txtMedNDC.Clear();
            txtMedName.Clear();
            txtMedDose.Clear();
            txtMedLOT.Clear();
            txtMfgr.ResetText();
            txtExpr.ResetText();
            txtAvailQty.Clear();
            txtPriceUnit.Clear();

            if(txtAvailQty.Text!= "0")
            {
                txtAddQty.Text = "0";
            }
            else
            {
                txtAddQty.Text = "0";
            }

        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        Int64 totalQty;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string medName = txtMedName.Text;
            string medNDC = txtMedNDC.Text;
            string medDose = txtMedDose.Text;
            string medLOT = txtMedLOT.Text;
            string mDate = txtMfgr.Text;
            string eDate = txtExpr.Text;
            Int64 quantity = Int64.Parse(txtAvailQty.Text);
            Int64 addQty = Int64.Parse(txtAddQty.Text);
            string unitPrice = txtPriceUnit.Text;

            totalQty = quantity + addQty;

            /*
            query = "update MedicineList set medName = '" + medName + "', medDose = '" + medDose + "', medLOT = '" + medLOT + "', mDate = '" + mDate + "', eDate = '" + eDate + "', quantity = " + totalQty + ", unitPrice = '" + unitPrice + "'" ;
            */
            query = "update MedicineList set medName = '" + medName + "', medDose = '" + medDose + "', medLOT = '" + medLOT + "', mDate = '" + mDate + "', eDate = '" + eDate + "', quantity = " + totalQty + ", unitPrice = '" + unitPrice + "' where medNDC = '"+ txtMedNDC.Text + "'";

            fn.setData(query, "Medicine Details Updated.");
        }

        
    }
}
