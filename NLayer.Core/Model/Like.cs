using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Like
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int TweetID { get; set; }

        public User User { get; set; } // Beğeni yapan kullanıcı
        public Tweet Tweet { get; set; } // Beğenilen tweet
    }
}
