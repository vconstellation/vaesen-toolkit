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
using VaesenToolkit.Stores;
using VaesenToolkit.ViewModels;

namespace VaesenToolkit.Views
{
    /// <summary>
    /// Interaction logic for Temp.xaml
    /// </summary>
    public partial class Temp : Page
    {
        private readonly SelectedNoteStore _selectedNoteStore;
        // NoteViewModel noteViewModel;
        public Temp()
        {
            InitializeComponent();
            _selectedNoteStore = new SelectedNoteStore();

            // DataContext = _selectedNoteStore;
            // noteViewModel = new NoteViewModel();

            this.DataContext = new NoteViewModel(_selectedNoteStore);
        }
    }
}
