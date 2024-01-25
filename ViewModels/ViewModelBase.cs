using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VaesenToolkit.Services;

namespace VaesenToolkit.ViewModels
{
    internal class ViewModelBase: INotifyPropertyChanged
    {
        // this regrabs the value when the event is raised, i e when the value is modified
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void Dispose()
        {

        }
    }
}
