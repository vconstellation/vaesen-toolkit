using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaesenToolkit.Models;

namespace VaesenToolkit.Stores
{
    public class NotesStore
    {
        public event Action<Note> NoteAdded;

        public async Task Add(Note note)
        {
            NoteAdded?.Invoke(note);
        }
    }
}
