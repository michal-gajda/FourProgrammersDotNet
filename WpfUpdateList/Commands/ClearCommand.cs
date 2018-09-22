namespace WpfUpdateList.Commands
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Windows.Input;
    using WpfUpdateList.Models;

    public sealed class ClearCommand : ICommand
    {
        private readonly ObservableCollection<SampleItem> items;

        public ClearCommand(ObservableCollection<SampleItem> items)
        {
            this.items = items;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return this.items.Any();
        }

        public void Execute(object parameter)
        {
            this.items.Clear();
        }
    }
}
