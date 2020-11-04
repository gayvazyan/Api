using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class PartieOrParty
    {
        public PartieOrParty()
        {
            PartieOrPartyList = new HashSet<PartieOrPartyList>();
        }

        [Key]
        public int PartieOrPartyId { get; set; }
        public int CandidateId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(16)]
        public string Prefix { get; set; }
        public int? Type { get; set; }
        [Column(TypeName = "ntext")]
        public string Platform { get; set; }
        [Column("Name_en")]
        [StringLength(255)]
        public string NameEn { get; set; }
        [Column("Prefix_en")]
        [StringLength(16)]
        public string PrefixEn { get; set; }
        [Column("Platform_en", TypeName = "ntext")]
        public string PlatformEn { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }

        [InverseProperty("PartieOrParty")]
        public virtual ICollection<PartieOrPartyList> PartieOrPartyList { get; set; }
    }
}
