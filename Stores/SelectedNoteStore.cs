using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaesenToolkit.Models;

namespace VaesenToolkit.Stores
{
    internal class SelectedNoteStore
    {
        private Note _selectedNote;
        
        public Note SelectedNote
        {
            get { return _selectedNote; }
            set
            {
                _selectedNote = value;
                SelectedNoteChanged?.Invoke();
            }
        }

        // update view when something changes
        public event Action SelectedNoteChanged;
    }
}
