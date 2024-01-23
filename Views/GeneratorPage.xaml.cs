using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace VaesenToolkit.Views
{
    /// <summary>
    /// Interaction logic for GeneratorPage.xaml
    /// </summary>
    public partial class GeneratorPage : Page
    {
        private JLo jlo;
        public GeneratorPage()
        {
            jlo = new JLo();
            jlo.InitJLo();
            InitializeComponent();
        }

        private void ButtonGenerate_Click(object sender, RoutedEventArgs e)
        {
            Hook hook = jlo.GetRandomHook();
            // genList.Items.Add();
            genList.Text = "Hook is: " + hook.InvitationContentToString() + hook.QuestGiverContentToString();
        }
    }
}
