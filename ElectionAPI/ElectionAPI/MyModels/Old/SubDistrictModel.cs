using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionAPI.MyModels
{
    public class SubDistrictModel
    {
        public string Region { get; set; }
        public string Community { get; set; }
        public string Residence { get; set; }
        public int District { get; set; }
        public int SubDistrict { get; set; }
        public string DistrictName { get; set; }
        public int EmployCount { get; set; }
        public string Address { get; set; }
        public int Zone { get; set; }


    }
}
