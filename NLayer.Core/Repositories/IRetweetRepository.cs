using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IRetweetRepository:IGenericRepository<Retweet>
    {
        void AddRetweet(int userId, int tweetId);
        void RemoveRetweet(int userId, int tweetId);
    }
}
