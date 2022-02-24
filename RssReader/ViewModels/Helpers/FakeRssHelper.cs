using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RssReader.Model.RssModel;

namespace RssReader.ViewModels.Helpers
{
    public class FakeRssHelper : IRssHelpers
    {
        public List<Items> GetPosts()
        {
            List<Items> items = new List<Items>
            {
                new Items()
                {
                    Title = "1st news",
                    Description = "Some example oof a very long to test when designing the app.",
                    PubDate = "Thu, 24 Feb 2022 22:00:00"
                },

                new Items()
                {
                    Title = "2nd news",
                    PubDate = "Thu, 24 Feb 2022 22:00:00"
                }
            };

            return items;
        }
    }
}
