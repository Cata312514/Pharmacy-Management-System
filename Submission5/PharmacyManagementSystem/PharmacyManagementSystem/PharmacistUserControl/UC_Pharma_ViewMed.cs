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
 
    public partial class UC_Pharma_ViewMed : UserControl
    {
        function fn = new function();
        string query;

        public UC_Pharma_ViewMed()
        {
            InitializeComponent();
        }

        private void UC_Pharma_ViewMed_Load(object sender, EventArgs e)
        {
            query = "select * from MedicineList";
            setDataGridView(query);
        }

        private void txtSearchMed_TextChanged(object sender, EventArgs e)
        {
            query = "select * from MedicineList where medName like '" + txtSearchMed.Text + "%'";
            setDataGridView(query);
        }

        private void setDataGridView(string query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView5.DataSource = ds.Tables[0];
        }

        string medID;

        private void guna2DataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medID = guna2DataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are your sure to Delete this item?", "Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from MedicineList where medNDC = '" + medID + "'";
                fn.setData(query, "Medicine Record Deleted.");
                UC_Pharma_ViewMed_Load(this, null);
            }
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_Pharma_ViewMed_Load(this, null);
        }

        
    }
}
