using ElectionAPI.Context;
using ElectionAPI.Model;
using ElectionAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionAPI.Services.SubDistrict
{
    public class SubDistrictService : Repository<SubDistricts>, ISubDistrictService
    {
        public SubDistrictService(ElectionsDbContext dbContext) : base(dbContext)
        {

        }
    }
}
