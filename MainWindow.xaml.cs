using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VaesenToolkit.Middleware;
using VaesenToolkit.Models;
using VaesenToolkit.Stores;
using VaesenToolkit.Views;

namespace VaesenToolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            /* var myTabItems = new List<TabItem>
            {
                new TabItem
                {
                    Header = "Generator",
                    Content = new Frame { Content = new GeneratorPage() }
                },
                new TabItem
                {
                    Header = "TempPage",
                    Content = new Frame { Content = new Temp() }
                }
            };

            <TabControl Grid.Row="0" ItemsSource="{Binding MyTabItems}" IsSynchronizedWithCurrentItem="True" />

            DataContext = new { MyTabItems = myTabItems }; */
        }

    }
}