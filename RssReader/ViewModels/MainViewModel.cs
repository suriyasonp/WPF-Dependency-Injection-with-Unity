using RssReader.ViewModels.Helpers;
using System.Collections.ObjectModel;
using static RssReader.Model.RssModel;

namespace RssReader.ViewModels
{
    public class MainViewModel
    {

        IRssHelpers _rssHelper;

        public ObservableCollection<Items> Items { get; set; }

        public MainViewModel(IRssHelpers rssHelper)
        {
            this._rssHelper = rssHelper;

            Items = new ObservableCollection<Items>();

            ReadRss();
        }

        private void ReadRss()
        {            
            var posts = _rssHelper.GetPosts();

            Items.Clear();

            foreach (var post in posts)
            {
                Items.Add(post);
            }
        }
    }
}
