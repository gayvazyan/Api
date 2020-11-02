using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class ElectionTypes
    {
        public ElectionTypes()
        {
            Elections = new HashSet<Elections>();
        }

        [Key]
        public int TypeId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public int? Tag { get; set; }
        public bool? IsRep { get; set; }
        [Column("UKey")]
        public int Ukey { get; set; }
        public int? MinBirthdate { get; set; }
        [Column("webName")]
        [StringLength(255)]
        public string WebName { get; set; }
        [Column("webName_en")]
        [StringLength(255)]
        public string WebNameEn { get; set; }
        [Column("webDesc")]
        [StringLength(255)]
        public string WebDesc { get; set; }
        [Column("webDesc_en")]
        [StringLength(255)]
        public string WebDescEn { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        public int? PartyRate { get; set; }
        public int? BlockRate { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<Elections> Elections { get; set; }
    }
}
