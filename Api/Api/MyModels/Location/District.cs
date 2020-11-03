using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyModels
{ 
    public partial class District
    {
        public int SubDistrictId { get; set; }
        public int? DistrictId { get; set; }
        public int? TypeId { get; set; }
        public string RegionName { get; set; }
        public string CommunityName { get; set; }
        public string Name { get; set; }
        public int CountOfBody { get; set; }
        public int? BodyList { get; set; }
        public int? PrecinctList { get; set; }
        public int BodyCount { get; set; }
        public int? EmployCount { get; set; }
    }
}
