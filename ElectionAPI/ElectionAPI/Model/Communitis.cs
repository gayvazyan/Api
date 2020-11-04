using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class Communitis
    {
        [Key]
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("Name_en")]
        [StringLength(64)]
        public string NameEn { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        [Column("positionX")]
        public double? PositionX { get; set; }
        [Column("positionY")]
        public double? PositionY { get; set; }
        [Column("pr")]
        [StringLength(10)]
        public string Pr { get; set; }
        [StringLength(3)]
        public string Consolidated { get; set; }
        public int? Zone { get; set; }

        [ForeignKey(nameof(RegionCode))]
        [InverseProperty(nameof(Regions.Communitis))]
        public virtual Regions RegionCodeNavigation { get; set; }
    }
}
