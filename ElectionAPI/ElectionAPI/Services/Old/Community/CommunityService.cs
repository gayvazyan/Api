﻿using ElectionAPI.Context;
using ElectionAPI.Model;
using ElectionAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionAPI.Services.Community
{
    public class CommunityService : Repository<Communitis>, ICommunityService
    {
        public CommunityService(ElectionsDbContext dbContext) : base(dbContext)
        {

        }
    }
}
