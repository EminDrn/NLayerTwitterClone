using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IFollowerRepository:IGenericRepository<Follower>
    {
        IEnumerable<User> GetFollowers(int userId);
        IEnumerable<User> GetFollowing(int userId);
        void AddFollower(int followerId, int followingId);
        void RemoveFollower(int followerId, int followingId);
    }
}
