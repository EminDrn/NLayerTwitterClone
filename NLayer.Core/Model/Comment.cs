using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TweetId { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }

    }

}
