using ElectionAPI.Context;
using ElectionAPI.Model;
using ElectionAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionAPI.Services.Region
{
    public class RegionService : Repository<Regions>, IRegionService
    {
        public RegionService(ElectionsDbContext dbContext) : base(dbContext)
        {

        }
    }
}
