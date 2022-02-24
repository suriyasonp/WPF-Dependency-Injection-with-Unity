using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RssReader.Model.RssModel;

namespace RssReader.ViewModels.Helpers
{
    public interface IRssHelpers
    {
        List<Items> GetPosts();
    }
}
