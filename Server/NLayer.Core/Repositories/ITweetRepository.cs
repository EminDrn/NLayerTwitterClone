﻿using NLayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface ITweetRepository: IGenericRepository<Tweet> 
    {
        IEnumerable<Tweet> GetTweetsByHashtag(string hashtag);
    }
}