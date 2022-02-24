using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using static RssReader.Model.RssModel;

namespace RssReader.ViewModels.Helpers
{
    public class RssHelper : IRssHelpers
    {
        public List<Items> GetPosts()
        {
            List<Items> posts = new();
            XmlSerializer xmlSerializer = new(typeof(RssFeed));

            using (WebClient client = new())
            {
                string xml =  Encoding.Default.GetString(client.DownloadData("https://www.posttoday.com/rss/src/world.xml"));

                using (Stream reader = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
                {
                    RssFeed ddcRssFeed = (RssFeed)xmlSerializer.Deserialize(reader);

                    posts = ddcRssFeed.Channel.Item;
                }
            }
            return posts;
        }
    }
}
