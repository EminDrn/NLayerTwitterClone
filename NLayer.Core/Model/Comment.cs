using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public int TweetID { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }

        public User User { get; set; } // Yorum yapan kullanıcı
        public Tweet Tweet { get; set; } // Yorum yapılan tweet

    }

}
