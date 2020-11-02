using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class PecMemberElectResult
    {
        [Key]
        public int PecMemberElectResultId { get; set; }
        public int? DistrictId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ElectionDate { get; set; }
        [StringLength(50)]
        public string SubDistrict { get; set; }
        [StringLength(50)]
        public string CommunityCode { get; set; }
        public int? Chairman { get; set; }
        public int? Secretary { get; set; }
        public bool? IsQueue { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        public int? SubDistrictCode { get; set; }
    }
}
