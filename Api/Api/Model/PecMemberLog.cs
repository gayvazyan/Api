using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("PecMember_Log")]
    public partial class PecMemberLog
    {
        public int Id { get; set; }
        public int? PecMemberId { get; set; }
        public int? DistrictId { get; set; }
        [StringLength(8)]
        public string SubDistrictCode { get; set; }
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(16)]
        public string Sertifcate { get; set; }
        [StringLength(256)]
        public string Phone { get; set; }
        public int? PartisInfoId { get; set; }
        public int? WorkPositionId { get; set; }
        public int? Tag { get; set; }
        public int? State { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StateDate { get; set; }
    }
}
