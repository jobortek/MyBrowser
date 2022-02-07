using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Main : Form
    {
  
        public Main()
        {
            InitializeComponent();
        }

       

        
        ChromiumWebBrowser browser;
        private void Main_Load(object sender, EventArgs e)
        {
            
            // Otvaramo Chromium i passamo url za HomePage
            browser = new ChromiumWebBrowser(txtUrl.Text);
            
            // popuni Panel - container sa učitanom stranicom
            browser.Dock = DockStyle.Fill;
            // dodajemo broswser u Panel control    
            this.pContainer.Controls.Add(browser);
           
        }

        // Za button Go učiitava starnicu
        private void btnGo_Click(object sender, EventArgs e)
        {
          
           browser.Load(txtUrl.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            if (browser.CanGoBack)
                browser.Back();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {

            if (browser.CanGoForward)
                browser.Forward();
        }

        // Pritiskom tipke enter učitava url
        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                browser.Load(txtUrl.Text);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            browser.Load(txtUrl.Text);
        }
    }
}
