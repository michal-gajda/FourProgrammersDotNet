namespace WpfUpdateList.ViewModels
{
    using System.Collections.ObjectModel;
    using WpfUpdateList.Models;

    public sealed partial class ShellViewModel
    {
        private ObservableCollection<SampleItem> items = new ObservableCollection<SampleItem>();

        private int progress = 0;

        private string title = "4programmers.net";


        public ObservableCollection<SampleItem> Items
        {
            get { return this.items; }
            set
            {
                this.items = value;
                this.OnPropertyChanged();
            }
        }

        public int Progress
        {
            get { return this.progress; }
            set
            {
                this.progress = value;
                this.OnPropertyChanged();
            }
        }

        public string Title
        {
            get { return this.title; }
            set
            {
                this.title = value;
                this.OnPropertyChanged();
            }
        }
    }
}
