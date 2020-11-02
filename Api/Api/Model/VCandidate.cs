using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VCandidate
    {
        public int CandidateId { get; set; }
        public int? ElectionId { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
        public int? CommissionId { get; set; }
        public int? State { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [Required]
        [StringLength(32)]
        public string StateName { get; set; }
        [StringLength(50)]
        public string CommissionName { get; set; }
        public int? DistrictId { get; set; }
        public bool? IsElected { get; set; }
        [StringLength(130)]
        public string Prefix { get; set; }
        [Column("FullName_en")]
        [StringLength(255)]
        public string FullNameEn { get; set; }
        [Column("Prefix_en")]
        [StringLength(130)]
        public string PrefixEn { get; set; }
        [StringLength(4)]
        public string OrderNum { get; set; }
    }
}
