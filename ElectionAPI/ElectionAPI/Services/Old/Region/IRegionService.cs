using ElectionAPI.Model;
using ElectionAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionAPI.Services.Region
{
    public interface IRegionService : IRepository<Regions>
    {
    }
}
