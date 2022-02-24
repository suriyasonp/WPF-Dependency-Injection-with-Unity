using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RssReader.Model
{
    public class RssModel
    {
        public class CData
        {
            public string ActualString { get; set; }
        }
        public class Items
        {
            [XmlElement(ElementName = "title")]
            public string Title { get; set; }

            [XmlElement(ElementName = "description")]
            public string Description { get; set; }

            [XmlElement(ElementName = "link")]
            public string Link { get; set; }

            [XmlElement(ElementName = "pubDate")]
            private string pubDate;

            public string PubDate
            {
                get { return pubDate; }
                set
                {
                    pubDate = value;
                    PublishedDate = DateTime.ParseExact(pubDate, "ddd, dd MMM yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                }
            }

            public DateTime PublishedDate { get; set; }

            [XmlElement(ElementName = "creator", Namespace = "http://purl.org/dc/elements/1.1/")]
            public string Creator { get; set; }
        }

        [XmlRoot(ElementName = "channel")]
        public class Channel
        {
            [XmlElement(ElementName = "item")]
            public List<Items> Item { get; set; }

            [XmlElement(ElementName = "link")]
            public string Link { get; set; }
        }

        [XmlRoot(ElementName = "rss")]
        public class RssFeed
        {
            [XmlElement(ElementName = "channel")]
            public Channel Channel { get; set; }
        }
    }
}
