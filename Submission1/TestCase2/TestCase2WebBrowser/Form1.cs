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

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboLocation.Text);
        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Text = "TestCase2WB - " + webBrowser3.Document.Title;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser3.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate(textBox1.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser3.Navigate("www.google.com");
        }
    }
}
