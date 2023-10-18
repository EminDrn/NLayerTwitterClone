using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Tweet
    {
        public  int Id { get; set; }
        public  int UserID { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int  CommentId { get; set; }

        public User User { get; set; } // Tweet'i oluşturan kullanıcı
        public List<Like> Likes { get; set; } // Tweet'in beğenileri
        public List<Retweet> Retweets { get; set; } // Tweet'in yeniden tweetlenmeleri
        public List<Comment> Comments { get; set; } // Tweet'in yorumları
        public List<TweetHashtag> TweetHashtags { get; set; } // Tweet'in hashtag'leri



    }
}
