using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyModels.Location
{
    public class ResultCvis
    {
        public int Id { get; set; }
        public int? DistrictId { get; set; }
        public int? TypeId { get; set; }
        public string Region { get; set; }
        public string Community { get; set; }
        public string Name { get; set; }
        public int CountOfBody { get; set; }
        public int? BodyList { get; set; }
        public int? PrecinctList { get; set; }
        public int BodyCount { get; set; }
        public int? Preliminary { get; set; }
    }
}
