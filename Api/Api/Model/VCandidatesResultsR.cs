using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VCandidatesResultsR
    {
        public int ElectionId { get; set; }
        public int CandidateId { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        [Column("value")]
        public int Value { get; set; }
        public int? State { get; set; }
        public int SubDistrictId { get; set; }
        public int? DistrictId { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(50)]
        public string CommunityCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(50)]
        public string DistrictName { get; set; }
        [StringLength(64)]
        public string CommunityName { get; set; }
        [StringLength(64)]
        public string RegionName { get; set; }
        [StringLength(130)]
        public string Prefix { get; set; }
        [StringLength(4)]
        public string OrderNum { get; set; }
        public int? Zone { get; set; }
    }
}
