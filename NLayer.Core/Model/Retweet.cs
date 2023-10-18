using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public  class Retweet
    {
        public int RetweetID { get; set; }
        public int UserID { get; set; }
        public int OriginalTweetID { get; set; }

        public User User { get; set; } // Yeniden tweetleyen kullanıcı
        public Tweet OriginalTweet { get; set; } // Yeniden tweetlenen orijinal tweet
    }
}
