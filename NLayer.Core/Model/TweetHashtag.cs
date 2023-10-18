using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class TweetHashtag
    {
        public int TweetID { get; set; }
      
        public int HashtagID { get; set; }
        public Hashtag Hashtag { get; set; }
        public Tweet Tweet { get; set; }
    }
}

