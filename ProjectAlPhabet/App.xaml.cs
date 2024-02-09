using System.Windows;

namespace ProjectAlPhabet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs args)
        {
            bool startMinimized = false;
            for (int i = 0; i != args.Args.Length; ++i)
            {
                if (args.Args[i] == "/StartMinimized")
                {
                    startMinimized = true;
                }
            }
            MainWindow mainWindow = new MainWindow();
            if (startMinimized)
            {
                mainWindow.WindowState = WindowState.Minimized;
            }
            mainWindow.Show();
        }

    }

}
