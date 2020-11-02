using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VExpPartieOrPartyPersons
    {
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
        [StringLength(9)]
        public string Passport { get; set; }
        public int? OrgId { get; set; }
        public int? WorkType { get; set; }
        [StringLength(64)]
        public string WorkPosition { get; set; }
        [StringLength(128)]
        public string WorkAddress { get; set; }
        public int? State { get; set; }
        public bool? IsElected { get; set; }
        [StringLength(130)]
        public string FullName { get; set; }
        [Column("CFullName")]
        [StringLength(255)]
        public string CfullName { get; set; }
        [Column("CState")]
        public int? Cstate { get; set; }
        [StringLength(255)]
        public string OrgName { get; set; }
        public int? ElectionId { get; set; }
        public bool? ElectName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ElectDate { get; set; }
        [StringLength(387)]
        public string ElectTypeName { get; set; }
        [StringLength(64)]
        public string CommunityName { get; set; }
        [StringLength(64)]
        public string RegionName { get; set; }
    }
}
