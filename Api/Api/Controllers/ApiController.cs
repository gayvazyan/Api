using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.MyModels;
using Api.MyModels.Location;
using Api.Services.Locations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        //private readonly IElectionsService _electionsService;
        private readonly ILocationService _locationService;

        public ApiController(
            ILogger<ApiController> logger,
            //IElectionsService electionsService,
            ILocationService locationService)
        {
            _logger = logger;
            // _electionsService = electionsService;
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
    }
}
