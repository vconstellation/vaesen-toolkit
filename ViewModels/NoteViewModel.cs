using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VaesenToolkit.Models;
using VaesenToolkit.Services;

namespace VaesenToolkit.ViewModels
{
    internal class NoteViewModel: ViewModelBase
    {
        private readonly Note note;
        private List<Note> notes {  get; set; }
        public string noteContent
        {
            get { return noteContent; }
            set { OnPropertyChanged(value); }
        }

        public ICommand AddNoteCommand { get; }
        public ICommand DeleteNoteCommand { get; }
        public ICommand EditNoteCommand { get; }
        public ICommand SaveChangesCommand { get; }
        
        public NoteViewModel()
        {
            note = new Note();
            notes = note.notes;

            Console.WriteLine("INSIDE NOTEVIEWMODEL CONSTRUCTOR");
            Console.WriteLine(notes);

            // create the cmds and add delegates
            AddNoteCommand = new RelayCommand(() => true, AddNote);
            //EditNoteCommand = new RelayCommand(() => SelectedNote != null, EditNote);
            //DeleteNoteCommand = new RelayCommand(() => SelectedNote != null, DeleteNote);
            //SaveChangesCommand = new RelayCommand(() => true, SaveChanges);
        }

        private void AddNote()
        {
            Console.WriteLine("Inside addnote");
            Note theNote = new Note();
            notes.Add(theNote);
        }
    }
}
