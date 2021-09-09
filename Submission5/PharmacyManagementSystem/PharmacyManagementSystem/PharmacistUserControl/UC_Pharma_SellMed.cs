using DGVPrinterHelper;
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
    public partial class UC_Pharma_SellMed : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;

        public UC_Pharma_SellMed()
        {
            InitializeComponent();
        }

        private void UC_Pharma_SellMed_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select medName from MedicineList where eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

       
        private void btnsync_Click(object sender, EventArgs e)
        {
            UC_Pharma_SellMed_Load(this, null);
        }

        private void txtSearchMed_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            query = "select medName from MedicineList where medName like '"+txtSearchMed.Text+ "%' and eDate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnits.Clear();
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            txtMedName.Text = name;
            query = "select medNDC, eDate, unitPrice from MedicineList where medName = '"+name+"'";
            ds = fn.getData(query);
            txtMedNDC.Text = ds.Tables[0].Rows[0][0].ToString();
            txtExpr.Text = ds.Tables[0].Rows[0][1].ToString();
            txtUnitPrice.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        
        private void txtUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtUnits.Text != "")
            {
                float unitPrice = float.Parse(txtUnitPrice.Text);
                Int64 units = Int64.Parse(txtUnits.Text);
                float totalAmount = unitPrice * units;
                txtTotal.Text = totalAmount.ToString();
            }
            else 
            {
                txtTotal.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if(txtMedNDC.Text !="")
            {
                query = "select quantity from MedicineList where medNDC = '" + txtMedNDC.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtUnits.Text);

                if(newQuantity >= 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedNDC.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpr.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtUnitPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtUnits.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTotal.Text;

                    totalAmount = totalAmount + int.Parse(txtTotal.Text);
                    lblFinTotal.Text = "USD " + totalAmount.ToString();

                    query = "update MedicineList set quantity = '" + newQuantity + "' where medNDC = '" + txtMedNDC + "'";
                    fn.setData(query, "Medicine Added.");
                }
                else
                {
                    MessageBox.Show("Medicine does not have enough stock.\n Only " + quantity + " left", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_Pharma_SellMed_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueAmount;
        string valueID;
        protected Int64 numUnit;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                numUnit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            { }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (valueID != null)
            {
                try { guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index); }
                catch { }
                finally
                { 
                    query = "select quantity from MedicineList where medNDC = '"+valueID+"'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + numUnit;

                    query = "update MedicineList set quantity = '" + newQuantity + "' where medNDC = '" + valueID + "'";
                    fn.setData(query, "Medicine Removed from Cart.");
                    totalAmount = totalAmount - valueAmount;
                    lblFinTotal.Text = "USD " + totalAmount.ToString();
                }
                UC_Pharma_SellMed_Load(this, null);
            }
        }


        private void btnPurPrnt_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payable Amount: " + lblFinTotal.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);

            totalAmount = 0;
            lblFinTotal.Text = "USD 00";
            guna2DataGridView1.DataSource = 0;
        }


        private void clearAll()
        {
            txtMedNDC.Clear();
            txtMedName.Clear();
            txtExpr.ResetText();
            txtUnits.Clear();
            txtUnitPrice.Clear();
            txtTotal.Clear();
        }


        
    }
}
