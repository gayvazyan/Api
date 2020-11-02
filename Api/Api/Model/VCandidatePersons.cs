using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VCandidatePersons
    {
        public int PersonId { get; set; }
        public int CandidateId { get; set; }
        [StringLength(32)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(32)]
        public string LastName { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(128)]
        public string Address { get; set; }
        public bool? MaleFemale { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthdate { get; set; }
        [Column("PN")]
        [StringLength(50)]
        public string Pn { get; set; }
        [StringLength(9)]
        public string Passport { get; set; }
        public int? WorkType { get; set; }
        public int? WorkPosition { get; set; }
        [StringLength(128)]
        public string WorkAddress { get; set; }
        public int? ElectionId { get; set; }
        public int? CommissionId { get; set; }
        public int? State { get; set; }
        public int? RecommendationId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [Required]
        [StringLength(32)]
        public string StateName { get; set; }
        [StringLength(32)]
        public string RecomName { get; set; }
        public int? DistrictId { get; set; }
    }
}
