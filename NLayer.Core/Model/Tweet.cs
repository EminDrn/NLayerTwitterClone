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
        public  int UserId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int  CommentId { get; set; }




    }
}
