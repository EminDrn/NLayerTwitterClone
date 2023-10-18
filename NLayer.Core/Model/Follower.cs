using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Follower
    {
        public int FollowerID { get; set; }
        public int FollowingID { get; set; }

        public User FollowerUser { get; set; } // Takipçi olan kullanıcı
        public User FollowingUser { get; set; } // Takip edilen kullanıcı
    }
}
