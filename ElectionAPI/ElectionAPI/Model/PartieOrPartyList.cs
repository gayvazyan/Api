using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class PartieOrPartyList
    {
        [Key]
        public int ListId { get; set; }
        public int? PartieOrPartyId { get; set; }
        public int? OrgId { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }

        [ForeignKey(nameof(PartieOrPartyId))]
        [InverseProperty("PartieOrPartyList")]
        public virtual PartieOrParty PartieOrParty { get; set; }
    }
}
