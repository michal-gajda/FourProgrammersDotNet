namespace WpfUpdateList.ViewModels
{
    using System.Windows.Input;
    using WpfUpdateList.Commands;

    public sealed partial class ShellViewModel
    {
        private ICommand clearCommand;

        private ICommand exitCommand;

        private ICommand runCommand;

        public ICommand ClearCommand
        {
            get
            {
                if (this.clearCommand == null)
                {
                    this.clearCommand = new ClearCommand(this.Items);
                }

                return this.clearCommand;
            }
            set
            {
                this.clearCommand = value;
            }
        }

        public ICommand ExitCommand
        {
            get
            {
                if (this.exitCommand == null)
                {
                    this.exitCommand = new ExitCommand();
                }

                return this.exitCommand;
            }
            set
            {
                this.exitCommand = value;
            }
        }

        public ICommand RunCommand
        {
            get
            {
                if (this.runCommand == null)
                {
                    this.runCommand = new RunCommand(this.backgroundWorker);
                }

                return this.runCommand;
            }
            set
            {
                this.runCommand = value;
            }
        }
    }
}
