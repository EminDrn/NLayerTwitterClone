using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface ILikeRepository:IGenericRepository<Like>
    {
        void AddLike(int userId, int tweetId);
        void RemoveLike(int userId, int tweetId);
    }
}
