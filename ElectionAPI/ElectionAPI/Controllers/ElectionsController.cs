using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.MyModels;
using Api.MyModels.Location;
using Api.Services.Locations;
using ElectionAPI.Context;
using ElectionAPI.Model;
using ElectionAPI.MyModels;
using ElectionAPI.Services.Community;
using ElectionAPI.Services.Election;
using ElectionAPI.Services.Region;
using ElectionAPI.Services.SubDistrict;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ElectionAPI.Controllers
{
  
    [ApiController]
    public class ElectionsController : ControllerBase
    {
        private readonly ILogger<ElectionsController> _logger;
        private readonly ILocationService _locationService;

        public ElectionsController(
            ILogger<ElectionsController> logger,
            ILocationService locationService)
        {
            _logger = logger;
            _locationService = locationService;
        }


        [HttpPost]
        [Route("pollingstations")]
        public IActionResult PollingStations([FromForm] string date)
        {
            Response response = new Response();
            try
            {
                if (string.IsNullOrEmpty(date))
                {
                    response.Status = "failed";
                    response.Message = "The date is required";
                    return StatusCode(406, response);
                }

                var dt = DateTime.ParseExact(date, "yyyy-M-d", null);

                var subDistrictsList = _locationService.GetSubDistrictsByDate(dt);
                List<PollingStation> pollingStations = new List<PollingStation>();
                pollingStations = subDistrictsList.Select(e => new PollingStation
                {
                    Id = e.SubDistrictId,
                    Constituency = e.DistrictId,
                    Name = e.Name,
                    Region = e.RegionName,
                    Community = e.CommunityName,
                    Address = e.Comment,
                    Voters_count = e.EmployCount
                }
                ).ToList();

                if (pollingStations.Count == 0)
                {
                    return NoContent();
                }
                return new JsonResult(pollingStations);
            }
            catch (Exception e)
            {
                response.Status = "failed";
                response.Message = e.Message;
                if (e.Message.Contains("was not recognized as a valid DateTime"))
                {
                    response.Message = response.Message + " The valid DateTime format is yyyy-MM-dd. e.g. 2019-12-13";
                    return StatusCode(406, response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
        }


        [HttpPost]
        [Route("pollingstations-local")]
        public IActionResult PollingStationsLocal([FromForm] string date)
        {
            Response response = new Response();
            try
            {
                if (string.IsNullOrEmpty(date))
                {
                    response.Status = "failed";
                    response.Message = "The date is required";
                    return StatusCode(406, response);
                }

                var dt = DateTime.ParseExact(date, "yyyy-M-d", null);

                var subDistrictsList = _locationService.GetSubDistrictsByDateLocal(dt);
                List<PollingStation> pollingStations = new List<PollingStation>();
                pollingStations = subDistrictsList.Select(e => new PollingStation
                {
                    Id = e.SubDistrictId,
                    Constituency = e.DistrictId,
                    Name = e.Name,
                    Region = e.RegionName,
                    Community = e.CommunityName,
                    Address = e.Comment,
                    Voters_count = e.EmployCount
                }
                ).ToList();

                if (pollingStations.Count == 0)
                {
                    return NoContent();
                }
                return new JsonResult(pollingStations);
            }
            catch (Exception e)
            {
                response.Status = "failed";
                response.Message = e.Message;
                if (e.Message.Contains("was not recognized as a valid DateTime"))
                {
                    response.Message = response.Message + " The valid DateTime format is yyyy-MM-dd. e.g. 2019-12-13";
                    return StatusCode(406, response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
        }


        [HttpPost]
        [Route("results")]
        public IActionResult ResultsForCVIS([FromForm] string date)
        {
            Response response = new Response();
            try
            {
                if (string.IsNullOrEmpty(date))
                {
                    response.Status = "failed";
                    response.Message = "The date is required";
                    return StatusCode(406, response);
                }

                var dt = DateTime.ParseExact(date, "yyyy-M-d", null);

                var districtsResult = _locationService.GetResultsByDate(dt);
                List<ResultCvis> resultsCvis = new List<ResultCvis>();
                resultsCvis = districtsResult.Select(e => new ResultCvis
                {
                    Id = e.SubDistrictId,
                    DistrictId = e.DistrictId,
                    TypeId = e.TypeId,
                    Region = e.RegionName,
                    Community = e.CommunityName,
                    Name = e.Name,
                    CountOfBody = e.CountOfBody,
                    BodyList = e.BodyList,
                    PrecinctList = e.PrecinctList,
                    BodyCount = e.BodyCount,
                    Preliminary = e.EmployCount
                }
                ).ToList();

                if (resultsCvis.Count == 0)
                {
                    return NoContent();
                }
                return new JsonResult(resultsCvis);
            }
            catch (Exception e)
            {
                response.Status = "failed";
                response.Message = e.Message;
                if (e.Message.Contains("was not recognized as a valid DateTime"))
                {
                    response.Message = response.Message + " The valid DateTime format is yyyy-MM-dd. e.g. 2019-12-13";
                    return StatusCode(406, response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
        }



        ////////////////---------------Old-------------/////////////////


        //private readonly ILogger<ElectionsController> _logger;

        //private readonly IElectionService _electionService;
        //private readonly ISubDistrictService _subDistrictService;
        //private readonly IRegionService _regionService;
        //private readonly ICommunityService _communityService;

        //public ElectionsController(ILogger<ElectionsController> logger,
        //                           IElectionService electionService,
        //                           ISubDistrictService  subDistrictService,
        //                           IRegionService regionService,
        //                           ICommunityService communityService)
        //{
        //    _logger = logger;
        //    _electionService = electionService;
        //    _subDistrictService = subDistrictService;
        //    _regionService = regionService;
        //    _communityService = communityService;
        //}

        //[HttpGet]
        //[Route("SubDistrictRep/{ElectionId}")]
        //public List<SubDistrictModel> SubDistrictRep(int ElectionId)
        //{


        //    List<SubDistricts> subDistricts = _subDistrictService.GetAll().ToList();

        //    List<Regions> regions = _regionService.GetAll().ToList();

        //    List<Communitis> communitis = _communityService.GetAll().ToList();

        //    var subDistrictQuery = (from subDistrict in subDistricts
        //                          where (subDistrict.ElectionId == ElectionId)
        //                          //INNER JOIN
        //                          join C in communitis on subDistrict.CommunityCode equals C.CommunityCode
        //                          join R in regions on subDistrict.RegionCode equals R.RegionCode
        //                          //LEFT OUTER JOIN
        //                          join C_1 in communitis on subDistrict.Settlement equals C_1.CommunityCode into cgroup
        //                          from C_1 in cgroup.DefaultIfEmpty()
        //                             orderby (subDistrict.DistrictId)
        //                          select new
        //                          {
        //                              Expr2 = R.Name,
        //                              Expr1 = C.Name,
        //                              Expr3 = C_1?.Name ?? String.Empty,
        //                              subDistrict.DistrictId,
        //                              subDistrict.SubDistrictCode,
        //                              subDistrict.Name,
        //                              subDistrict.EmployCount,
        //                              subDistrict.Comment,
        //                              subDistrict.Zone,
        //                          })
        //                       .ToList();

        //    List<SubDistrictModel> SubDistrictList = new List<SubDistrictModel>();

        //    foreach (var item in subDistrictQuery)
        //    {
        //        SubDistrictModel subDistrict = new SubDistrictModel()
        //        {
        //            Region = item.Expr2,
        //            Community = item.Expr1,
        //            Residence=item.Expr3,
        //            District = Convert.ToInt32(item.DistrictId),
        //            SubDistrict = Convert.ToInt32(item.SubDistrictCode),
        //            DistrictName =item.Name,
        //            EmployCount= Convert.ToInt32(item.EmployCount),
        //            Address=item.Comment,
        //            Zone= Convert.ToInt32(item.Zone)
        //        };

        //        SubDistrictList.Add(subDistrict);
        //    }

        //    return SubDistrictList;
        //}



        //[HttpPost]
        //[Route("SubDistrictTim")]
        //public List<SubDistrictModel> SubDistrictTim([FromForm] string ElectionDay)
        //{

        //    List<Elections> electionList = _electionService.GetAll().ToList();

        //    List<SubDistricts> subDistricts = _subDistrictService.GetAll().ToList();

        //    List<Regions> regions = _regionService.GetAll().ToList();

        //    List<Communitis> communitis = _communityService.GetAll().ToList();


        //    //part of SQL Query
        //    var subDistrictQuery = (from subDistrict in subDistricts

        //                            //INNER JOIN
        //                            join C in communitis on subDistrict.CommunityCode equals C.CommunityCode
        //                            join R in regions on subDistrict.RegionCode equals R.RegionCode
        //                            join E in electionList on subDistrict.ElectionId equals E.ElectionId

        //                            //LEFT OUTER JOIN
        //                            join C_1 in communitis on subDistrict.Settlement equals C_1.CommunityCode into cgroup
        //                            from C_1 in cgroup.DefaultIfEmpty()

        //                            where (E.SrartDate.ToString("dd.MM.yyyy") == ElectionDay)
        //                            orderby (subDistrict.DistrictId)
        //                            select new
        //                            {
        //                                Expr2 = R.Name,
        //                                Expr1 = C.Name,
        //                                Expr3 = C_1?.Name ?? String.Empty,
        //                                subDistrict.DistrictId,
        //                                subDistrict.SubDistrictCode,
        //                                subDistrict.Name,
        //                                subDistrict.EmployCount,
        //                                subDistrict.Comment,
        //                                subDistrict.Zone,
        //                            })
        //                       .ToList();




        //    List<SubDistrictModel> SubDistrictList = new List<SubDistrictModel>();
        //    List<SubDistrictModel> SubDistricts = new List<SubDistrictModel>();


        //    foreach (var item in subDistrictQuery)
        //    {
        //        SubDistrictModel subDistrict = new SubDistrictModel()
        //        {
        //            Region = item.Expr2,
        //            Community = item.Expr1,
        //            Residence = item.Expr3,
        //            District = Convert.ToInt32(item.DistrictId),
        //            SubDistrict = Convert.ToInt32(item.SubDistrictCode),
        //            DistrictName = item.Name,
        //            EmployCount = Convert.ToInt32(item.EmployCount),
        //            Address = item.Comment,
        //            Zone = Convert.ToInt32(item.Zone)
        //        };

        //        SubDistrictList.Add(subDistrict);
        //    }

        //    //remove duplicate SubDistict

        //    SubDistricts = SubDistrictList.GroupBy(p => p.DistrictName).Select(r => r.First()).ToList();


        //    return SubDistricts;
        //}

    }
}
