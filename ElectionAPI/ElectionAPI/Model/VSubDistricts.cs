using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class VSubDistricts
    {
        public int SubDistrictId { get; set; }
        public int ElectionId { get; set; }
        [Required]
        [StringLength(50)]
        public string SubDistrictCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        public int? EmployCount { get; set; }
        [StringLength(255)]
        public string Comment { get; set; }
        public int? DistrictId { get; set; }
        [Required]
        [StringLength(2)]
        public string DistrictCode { get; set; }
        [StringLength(50)]
        public string DistrictName { get; set; }
        [Required]
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(64)]
        public string RegionName { get; set; }
        [StringLength(50)]
        public string CommunityCode { get; set; }
        [StringLength(64)]
        public string CommunityName { get; set; }
        public int? Zone { get; set; }
    }
}
