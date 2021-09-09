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
    public partial class UC_Pharma_DashBrd : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        Int64 count;

        public UC_Pharma_DashBrd()
        {
            InitializeComponent();
        }

        private void UC_Pharma_DashBrd_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        public void loadChart()
        {
            query = "select count (medName) from MedicineList where eDate >= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicine"].Points.AddXY("Medicine Validity Chart", count);

            query = "select count (medName) from MedicineList where eDate <= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicine"].Points.AddXY("Medicine Validity Chart", count);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicine"].Points.Clear();
            chart1.Series["Expired Medicine"].Points.Clear();
            loadChart();
        }

    }
}
