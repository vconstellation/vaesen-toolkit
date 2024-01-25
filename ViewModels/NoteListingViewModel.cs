using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaesenToolkit.Models;
using VaesenToolkit.Stores;

namespace VaesenToolkit.ViewModels
{
    internal class NoteListingViewModel: ViewModelBase
    {
        //encapsulating here
        private readonly ObservableCollection<NoteListingItemViewModel> _items;

        private readonly SelectedNoteStore _selectedNoteStore;
        public IEnumerable<NoteListingItemViewModel> noteListingItemViewModels => _items;

        private NoteListingItemViewModel _selectedNoteListingItemViewModel;
        
        public NoteListingItemViewModel SelectedNoteListingItemViewModel
        {
            get
            {
                return _selectedNoteListingItemViewModel;
            }
            set
            {
                _selectedNoteListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedNoteListingItemViewModel));

                _selectedNoteStore.SelectedNote = _selectedNoteListingItemViewModel?.Note;
                Console.WriteLine("SELECTEDNOTELISTINGITEMVIEWMODEL");
                Console.WriteLine(_selectedNoteStore);
            }
        }

        public NoteListingViewModel(SelectedNoteStore selectedNoteStore)
        {
            _selectedNoteStore = selectedNoteStore;
            _items = new ObservableCollection<NoteListingItemViewModel>();
            _items.Add(new NoteListingItemViewModel(new Note(1, "contextmade1")));
            _items.Add(new NoteListingItemViewModel(new Note(2, "contextmade4")));
            _items.Add(new NoteListingItemViewModel(new Note(3, "contextmade66")));
            Console.WriteLine("INSIDE NOTE LISTING VIEWMODEL");
            foreach (var item in _items)
            {
                Console.WriteLine(item.NoteContent);
            }
        }
    }
}
