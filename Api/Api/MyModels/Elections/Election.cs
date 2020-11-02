using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MyModels
{ 
    public class Election
    {
        public int ElectionId { get; set; }
        public string ElectionType { get; set; }
        public string ElectionTypeEn { get; set; }
        public string ElectionState { get; set; }
        public int? District { get; set; }
        public string Region { get; set; }
        public string RegionEn { get; set; }
        public string Community { get; set; }
        public string CommunityEn { get; set; }
        public string Date { get; set; }
    }
}
