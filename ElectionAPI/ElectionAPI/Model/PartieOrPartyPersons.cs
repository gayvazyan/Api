using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class PartieOrPartyPersons
    {
        [Key]
        public int PersonId { get; set; }
        public int CandidateId { get; set; }
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
        [StringLength(16)]
        public string Passport { get; set; }
        public int? OrgId { get; set; }
        public int? WorkType { get; set; }
        [StringLength(64)]
        public string WorkPosition { get; set; }
        [StringLength(128)]
        public string WorkAddress { get; set; }
        public int? State { get; set; }
        public bool? IsElected { get; set; }
        [Column("FirstName_en")]
        [StringLength(32)]
        public string FirstNameEn { get; set; }
        [Column("MiddleName_en")]
        [StringLength(64)]
        public string MiddleNameEn { get; set; }
        [Column("LastName_en")]
        [StringLength(32)]
        public string LastNameEn { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        public int? ElectedType { get; set; }
        public int? ListType { get; set; }
        public int? Reference { get; set; }
        public int? Zone { get; set; }
        public int? MinorityId { get; set; }
    }
}
