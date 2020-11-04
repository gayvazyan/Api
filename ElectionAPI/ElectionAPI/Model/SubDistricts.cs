using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class SubDistricts
    {
        public SubDistricts()
        {
            CandidatesResults = new HashSet<CandidatesResults>();
        }

        [Key]
        public int SubDistrictId { get; set; }
        [Required]
        [StringLength(50)]
        public string SubDistrictCode { get; set; }
        public int ElectionId { get; set; }
        public int? DistrictId { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [StringLength(50)]
        public string RegionCode { get; set; }
        [StringLength(50)]
        public string CommunityCode { get; set; }
        public int? EmployCount { get; set; }
        [StringLength(255)]
        public string Comment { get; set; }
        [Column("ENum1")]
        public int? Enum1 { get; set; }
        [Column("ENum2")]
        public int? Enum2 { get; set; }
        public int? NonRegList { get; set; }
        public int? OtherCommList { get; set; }
        public int? PoliceList { get; set; }
        public int? StationarList { get; set; }
        public int? BodyList { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        public double? PoisitionX { get; set; }
        public double? PoisitionY { get; set; }
        [StringLength(50)]
        public string Settlement { get; set; }
        public int? Zone { get; set; }

        [ForeignKey(nameof(ElectionId))]
        [InverseProperty(nameof(Elections.SubDistricts))]
        public virtual Elections Election { get; set; }
        [InverseProperty("SubDistrict")]
        public virtual ICollection<CandidatesResults> CandidatesResults { get; set; }
    }
}
