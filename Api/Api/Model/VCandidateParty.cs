using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VCandidateParty
    {
        public int CandidateId { get; set; }
        public int? ElectionId { get; set; }
        public int? CommissionId { get; set; }
        public int? State { get; set; }
        public int? RecommendationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(16)]
        public string Prefix { get; set; }
        public int? Type { get; set; }
        [StringLength(50)]
        public string CommissionsName { get; set; }
        [StringLength(32)]
        public string RecName { get; set; }
        [Required]
        [StringLength(32)]
        public string StateName { get; set; }
        public int PartieOrPartyId { get; set; }
        public int? DistrictId { get; set; }
        [StringLength(4)]
        public string OrderNum { get; set; }
    }
}
