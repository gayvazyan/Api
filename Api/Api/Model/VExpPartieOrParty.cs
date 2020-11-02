using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VExpPartieOrParty
    {
        public int CandidateId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(16)]
        public string Prefix { get; set; }
        public int? OrgId { get; set; }
        [StringLength(255)]
        public string OrgName { get; set; }
        public int? ElectionId { get; set; }
        public int? DistrictId { get; set; }
        public int? State { get; set; }
        public int? CommissionId { get; set; }
    }
}
