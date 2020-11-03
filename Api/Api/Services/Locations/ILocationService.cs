using Api.MyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services.Locations
{
    public interface ILocationService
    {
        List<SubDistrict> GetSubDistrictsByDate(DateTime date);
        List<SubDistrict> GetSubDistrictsByDateLocal(DateTime date);
        List<District> GetResultsByDate(DateTime date);

    }
}
