using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VExpCommissionPersons
    {
        [StringLength(130)]
        public string FullName { get; set; }
        public int PersonId { get; set; }
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
        [Column("EMail")]
        [StringLength(50)]
        public string Email { get; set; }
        public bool? MaleFemale { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthdate { get; set; }
        [StringLength(9)]
        public string Passport { get; set; }
        public int? WorkPosition { get; set; }
        public int? CommissionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ActivityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TerminationDate { get; set; }
        public int? State { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [StringLength(32)]
        public string WorkTypesName { get; set; }
        [StringLength(64)]
        public string CommunityName { get; set; }
        [StringLength(64)]
        public string RegionName { get; set; }
        [StringLength(50)]
        public string DistrictName { get; set; }
        [StringLength(250)]
        public string StateName { get; set; }
        [StringLength(50)]
        public string Round { get; set; }
    }
}
