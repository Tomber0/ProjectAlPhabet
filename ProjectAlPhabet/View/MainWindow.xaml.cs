using System.Windows;

namespace ProjectAlPhabet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // read from .ini
            DataContext = new ModelView.MainWindowModelView();
            InitializeComponent();
        }
    }
}