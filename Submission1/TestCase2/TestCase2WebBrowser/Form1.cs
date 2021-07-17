using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCase2WebBrowser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser3.Navigate(cboLocation.Text);
            }
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser3.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser3.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate(cboLocation.Text);
        }
    }
}
