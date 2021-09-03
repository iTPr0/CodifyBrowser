using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Codify_Community
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer container = new AppContainer();

            container.Tabs.Add(

                new TitleBarTab(container)
                {
                    Content = new frmBrowser
                    {
                        Text = "Codify Community"
                    }
                }
            );

            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
