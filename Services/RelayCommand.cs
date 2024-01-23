using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VaesenToolkit.Services
{
    internal class RelayCommand: ICommand
    {
        // A delegate that takes no parameters and returns a bool value
        private readonly Func<bool> canExecute;

        // A delegate that takes no parameters and returns void
        private readonly Action execute;

        public RelayCommand(Func<bool> canExecute, Action execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }

        // The event that is raised when the command availability changes
        public event EventHandler CanExecuteChanged;

        // The method that invokes the canExecute delegate and returns its result
        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        // The method that invokes the execute delegate
        public void Execute(object parameter)
        {
            execute();
        }

        // The method that raises the CanExecuteChanged event
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }


    }
}
