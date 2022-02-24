using RssReader.ViewModels;
using System.Windows;
using Unity;

namespace RssReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [Dependency]
        public MainViewModel ViewModel
        {
            set
            {
                DataContext = value;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
