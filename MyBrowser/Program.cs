using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());

            // dodajem support za više tabova zato ovo gore mora biti zakomentirano i dodano sljedeće 
            Tabs container = new Tabs();
            container.Tabs.Add(new EasyTabs.TitleBarTab(container)
            {
                Content = new Main
                {
                    Text = "New Tab"
                }

            });
            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);

        }
    }
}
