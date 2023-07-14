using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeVideoDownloader.Commands;
using YoutubeVideoDownloader.View.UCViews;

namespace YoutubeVideoDownloader.ViewModels
{
    public class MainWindowViewModel:BaseViewModel
    {
        public RelayCommand ClickedCount { get; set; }
        private string _url;

        public string url
        {
            get { return _url; }
            set { _url = value; OnPropertyChanged(); }
        }


        public MainWindowViewModel()
        {
            ClickedCount = new RelayCommand((obj) =>
            {
                DownloadPercentUC downloadPercentUC = new DownloadPercentUC();
                App.Progress.Children.Add(downloadPercentUC);
               
            });
        }
    }
}
