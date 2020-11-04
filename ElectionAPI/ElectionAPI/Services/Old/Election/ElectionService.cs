using ElectionAPI.Context;
using ElectionAPI.Model;
using ElectionAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionAPI.Services.Election
{
    public class ElectionService: Repository<Elections>, IElectionService
    {
        public ElectionService(ElectionsDbContext dbContext) : base(dbContext)
        {

        }
    }
}
