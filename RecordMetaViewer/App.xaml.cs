using RecordMetaViewer.Data;
using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace RecordMetaViewer
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Helper.Channels = Helper.GetChannels();
            MainWindow mw;
            if (e.Args.Length <= 0)
            {
                mw = new MainWindow();
            }
            else
            {
                mw = new MainWindow(e.Args.First());
            }
            mw.Show();
        }

    }
}
