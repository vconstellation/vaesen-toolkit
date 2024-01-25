using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VaesenToolkit.Models;

namespace VaesenToolkit.ViewModels
{
    internal class NoteListingItemViewModel : ViewModelBase
    {
        public Note Note { get; }
        public string NoteContent => Note.noteContext;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public NoteListingItemViewModel(Note note)
        {
            Note = note;
        }
    }
}
