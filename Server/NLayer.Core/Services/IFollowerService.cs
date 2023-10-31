using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IFollowerService:IService<Follower>
    {
        IEnumerable<User> GetFollowers(int userId);
        IEnumerable<User> GetFollowing(int userId);
        Task AddFollowerAsync(int followerId, int followingId);
        Task RemoveFollowerAsync(int followerId, int followingId);
    }
}
