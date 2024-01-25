using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaesenToolkit.Models;
using VaesenToolkit.Services;
using VaesenToolkit.Stores;

namespace VaesenToolkit.ViewModels
{
    internal class NoteViewModel: ViewModelBase
    {
        public NoteListingViewModel NoteListingViewModel { get; }
        public NoteDetailsViewModel NoteDetailsViewModel { get; }
        public RelayCommand AddNoteCommand { get; }

        public NoteViewModel(SelectedNoteStore _selectedNoteStore)
        {
            NoteListingViewModel = new NoteListingViewModel(_selectedNoteStore);
            NoteDetailsViewModel = new NoteDetailsViewModel(_selectedNoteStore);
            Console.WriteLine("INSIDE NOTE VIEW MODEL");
            Console.WriteLine(NoteDetailsViewModel.detailContent);
        }
    }
}
