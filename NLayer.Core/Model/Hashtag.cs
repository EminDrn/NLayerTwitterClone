using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Hashtag
    {
        public int HashtagID { get; set; }
        public string Tag { get; set; }


        public List<TweetHashtag> TweetHashtags { get; set; } // Hashtag'i kullanan tweet'ler

    }

}
