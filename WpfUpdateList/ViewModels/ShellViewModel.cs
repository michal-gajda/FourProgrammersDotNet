namespace WpfUpdateList.ViewModels
{
    using System.ComponentModel;
    using System.Threading;
    using WpfUpdateList.Models;

    public sealed partial class ShellViewModel : ViewModelBase
    {
        private readonly BackgroundWorker backgroundWorker = new BackgroundWorker();

        public ShellViewModel()
        {
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += (sender, args) =>
            {
                var worker = sender as BackgroundWorker;

                for (int i = 0; i <= 100; i++)
                {
                    var item = new SampleItem
                    {
                        Id = i,
                        Name = string.Format("Progress {0}%", i)
                    };

                    worker.ReportProgress(i, item);
                    Thread.Sleep(100);
                }
            };
            this.backgroundWorker.ProgressChanged += (sender, args) =>
            {
                var item = args.UserState as SampleItem;

                this.Items.Add(item);

                this.Progress = args.ProgressPercentage;
            };
            this.backgroundWorker.RunWorkerCompleted += (sender, args) => { this.Progress = 0; };
        }
    }
}
