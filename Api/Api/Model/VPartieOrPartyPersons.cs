using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VPartieOrPartyPersons
    {
        public int PersonId { get; set; }
        public int PartieOrPartyId { get; set; }
        public int? Number { get; set; }
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
        [StringLength(10)]
        public string Pn { get; set; }
        [StringLength(9)]
        public string Passport { get; set; }
        public int? OrgId { get; set; }
        public int? WorkType { get; set; }
        [StringLength(64)]
        public string WorkPosition { get; set; }
        [StringLength(128)]
        public string WorkAddress { get; set; }
        public int? State { get; set; }
        [StringLength(255)]
        public string PartyName { get; set; }
        [StringLength(16)]
        public string PartyPrefix { get; set; }
        [StringLength(255)]
        public string OrgName { get; set; }
        public int? OrgType { get; set; }
        [Required]
        [StringLength(32)]
        public string StateName { get; set; }
        public int CandidateId { get; set; }
        public int? ElectionId { get; set; }
        public int? DistrictId { get; set; }
        [Column("FirstName_en")]
        [StringLength(32)]
        public string FirstNameEn { get; set; }
        [Column("MiddleName_en")]
        [StringLength(64)]
        public string MiddleNameEn { get; set; }
        [Column("LastName_en")]
        [StringLength(32)]
        public string LastNameEn { get; set; }
        public int? ElectedType { get; set; }
        public int? ListType { get; set; }
        public int? Reference { get; set; }
        public int? MinorityId { get; set; }
        public int? Zone { get; set; }
    }
}
