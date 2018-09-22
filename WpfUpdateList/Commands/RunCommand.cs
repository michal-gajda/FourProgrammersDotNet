namespace WpfUpdateList.Commands
{
    using System;
    using System.ComponentModel;
    using System.Windows.Input;

    public sealed class RunCommand : ICommand
    {
        private readonly BackgroundWorker backgroundWorker;

        public RunCommand(BackgroundWorker backgroundWorker)
        {
            this.backgroundWorker = backgroundWorker;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (!this.backgroundWorker.IsBusy)
            {
                this.backgroundWorker.RunWorkerAsync();
            }
        }
    }
}