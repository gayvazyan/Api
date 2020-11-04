using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class Districts
    {
        [Key]
        public int DistrictId { get; set; }
        [Required]
        [StringLength(2)]
        public string DistrictCode { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("Name_en")]
        [StringLength(50)]
        public string NameEn { get; set; }
        public int? CommissionPersonCount { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
