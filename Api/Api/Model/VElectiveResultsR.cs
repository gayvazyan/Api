using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VElectiveResultsR
    {
        public int ElectionId { get; set; }
        [StringLength(50)]
        public string DistrictName { get; set; }
        [StringLength(64)]
        public string RegionName { get; set; }
        [StringLength(64)]
        public string CommunityName { get; set; }
        [StringLength(64)]
        public string SubDistrictName { get; set; }
        public int SubDistrictId { get; set; }
        public int CountOfBody { get; set; }
        public int TotalCards { get; set; }
        public int TotalEnvelopes { get; set; }
        public int ElNum { get; set; }
        public int? ElNum1 { get; set; }
        public int BadElecCards { get; set; }
        public int BadEnvelopes { get; set; }
        public int BodyCount { get; set; }
        public int NoElecCards { get; set; }
        public int ElecCardsEl { get; set; }
        public int TrueCards { get; set; }
        public int FalseCards { get; set; }
        public int CardsCount { get; set; }
        public int EnvelopesCount { get; set; }
        [Column("NoRSize")]
        public int NoRsize { get; set; }
        [Column("NoRSize1")]
        public int? NoRsize1 { get; set; }
        [Column("NoRSize2")]
        public int? NoRsize2 { get; set; }
        [Column("NoRSize3")]
        public int? NoRsize3 { get; set; }
        [Column("NoRSize4")]
        public int? NoRsize4 { get; set; }
        [Column("NoRSizeR")]
        public int? NoRsizeR { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnterDate { get; set; }
        public int? State { get; set; }
        public int? EnterUser { get; set; }
        public bool? Control { get; set; }
        [StringLength(50)]
        public string CommunityCode { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        public int? DistrictId { get; set; }
        [Required]
        [StringLength(2)]
        public string DistrictCode { get; set; }
        public int? BodyList { get; set; }
        public int? NonRegList { get; set; }
        public int? OtherCommList { get; set; }
        public int? PoliceList { get; set; }
        public int? StationarList { get; set; }
        public int? CaughtList { get; set; }
        public int? PrecinctList { get; set; }
        public int? TotalList { get; set; }
        public int? BodyList2 { get; set; }
        public int? PrecinctList2 { get; set; }
        [Column("NonRegList_ID")]
        public int? NonRegListId { get; set; }
        [Column("OtherCommList_ID")]
        public int? OtherCommListId { get; set; }
        [Column("PoliceList_ID")]
        public int? PoliceListId { get; set; }
        [Column("StationarList_ID")]
        public int? StationarListId { get; set; }
        [Column("CaughtList_ID")]
        public int? CaughtListId { get; set; }
        [Column("PrecinctList_ID")]
        public int? PrecinctListId { get; set; }
        [Column("BodyList_ID")]
        public int? BodyListId { get; set; }
        [Column("BodyCount_ID")]
        public int? BodyCountId { get; set; }
        public int? Zone { get; set; }
    }
}
