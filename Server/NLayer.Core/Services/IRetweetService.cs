using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IRetweetService:IService<Retweet>
    {
        Task AddRetweetAsync(int userId, int tweetId);
        Task RemoveRetweetAsync(int userId, int tweetId);
    }
}
