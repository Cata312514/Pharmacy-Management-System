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
    public partial class UC_Pharma_ValMed : UserControl
    {
        function fn = new function();
        string query;

        public UC_Pharma_ValMed()
        {
            InitializeComponent();
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select * from MedicineList where eDate >= getdate()";
                setDataGridView(query, "Valid Medicine", Color.Black);
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select * from MedicineList where eDate <= getdate()";
                setDataGridView(query, "Expired Medicine", Color.Red);
            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from MedicineList";
                setDataGridView(query, "", Color.Black);
            }
        }

        private void setDataGridView(string query, string labelName, Color col)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
            lblSet.Text = labelName;
            lblSet.ForeColor = col;
        }

        private void UC_Pharma_ValMed_Load(object sender, EventArgs e)
        {
            lblSet.Text = "";
        }
    }
}
