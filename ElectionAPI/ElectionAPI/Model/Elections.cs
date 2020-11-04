using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class Elections
    {
        public Elections()
        {
            SubDistricts = new HashSet<SubDistricts>();
        }

        [Key]
        public int ElectionId { get; set; }
        public int TypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SrartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int StateId { get; set; }
        public int? LocalDistrictId { get; set; }
        [StringLength(3)]
        public string CommunityCode { get; set; }
        public bool? VisibleInWeb { get; set; }
        public bool? IsExtra { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        public int? PartyRate { get; set; }
        public int? BlockRate { get; set; }
        public string Comment { get; set; }
        [Column("Comment_en")]
        public string CommentEn { get; set; }
        public int? Mandat { get; set; }

        [ForeignKey(nameof(StateId))]
        [InverseProperty(nameof(ElectionStates.Elections))]
        public virtual ElectionStates State { get; set; }
        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(ElectionTypes.Elections))]
        public virtual ElectionTypes Type { get; set; }
        [InverseProperty("Election")]
        public virtual ICollection<SubDistricts> SubDistricts { get; set; }
    }
}
