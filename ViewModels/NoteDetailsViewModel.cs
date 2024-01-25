using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaesenToolkit.Models;
using VaesenToolkit.Stores;

namespace VaesenToolkit.ViewModels
{
    internal class NoteDetailsViewModel: ViewModelBase
    {
        private readonly SelectedNoteStore _selectedNoteStore;

        private Note note => _selectedNoteStore.SelectedNote;
        public string detailContent => note?.noteContext ?? "Unknown";

        // this lives always, so we need to add a manual dispose method in ViewModelBase;
        public NoteDetailsViewModel(SelectedNoteStore selectedNoteStore)
        {
            // this.detailContent = "Detail temp mock";
            this._selectedNoteStore = selectedNoteStore;

            this._selectedNoteStore.SelectedNoteChanged += _selectedNoteStore_SelectedNoteChanged;
        }

        protected override void Dispose()
        {
            _selectedNoteStore.SelectedNoteChanged -= _selectedNoteStore_SelectedNoteChanged;

            base.Dispose();
        }

        private void _selectedNoteStore_SelectedNoteChanged()
        {
            Console.WriteLine("INSIDE SELECTEDNOTESTORE_SELCETEDNOTECHANGED");
            OnPropertyChanged(nameof(detailContent));
        }
    }
}
