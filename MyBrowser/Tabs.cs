using EasyTabs;
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
    public partial class Tabs : TitleBarTabs
    {
        public Tabs()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
           
        }

        //  overrideamo create tab metodu da možemo dodati naš form u chromium tab
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Main { Text = "New Tab" }
            };
        }

    }
}
