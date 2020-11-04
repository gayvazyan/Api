using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionAPI.MyModels
{
    public class ElectionForGet
    {
        public string ElectionType { get; set; }
        public string District { get; set; }
        public string SubDistrict { get; set; }
        public string Region { get; set; }
        public string Community { get; set; }
        
    }
}
