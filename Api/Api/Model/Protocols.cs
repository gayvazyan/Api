using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class Protocols
    {
        public int SubDistrictId { get; set; }
        [Required]
        [StringLength(50)]
        public string SubDistrictCode { get; set; }
        public int ElectionId { get; set; }
        public int? DistrictId { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(50)]
        public string RegionCode { get; set; }
        [StringLength(50)]
        public string CommunityCode { get; set; }
        public int? EmployCount { get; set; }
        [StringLength(255)]
        public string Comment { get; set; }
        public int State { get; set; }
    }
}
