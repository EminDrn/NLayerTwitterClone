using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Follower
    {
        public int Id { get; set; }
        public int FollowerUserId { get; set; }

        public int FollowingUserId { get; set; }

    }
}
