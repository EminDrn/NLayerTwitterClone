using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public  class Retweet
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OriginalTweetId { get; set; }

    }
}
