using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class VGeoresults
    {
        [Column("ID")]
        public int Id { get; set; }
        public int CandidateId { get; set; }
        [StringLength(130)]
        public string Prefix { get; set; }
        [Column("value")]
        public int Value { get; set; }
        public int? State { get; set; }
        public int SubDistrictId { get; set; }
        [Required]
        [StringLength(50)]
        public string SubDistrictCode { get; set; }
        [StringLength(64)]
        public string SubDistrictName { get; set; }
        public int? DistrictId { get; set; }
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
        public int? ElectionId { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        public int BodyCount { get; set; }
        [StringLength(4)]
        public string OrderNum { get; set; }
    }
}
