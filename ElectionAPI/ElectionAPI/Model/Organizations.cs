using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class Organizations
    {
        public Organizations()
        {
            Watchers = new HashSet<Watchers>();
        }

        [Key]
        public int OrgId { get; set; }
        [Required]
        [StringLength(13)]
        public string OrgCode { get; set; }
        public int? OrgType { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(10)]
        public string Sertificate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnterDate { get; set; }
        [StringLength(255)]
        public string Comment { get; set; }
        [Column("Name_en")]
        [StringLength(255)]
        public string NameEn { get; set; }
        [Column("Comment_en")]
        [StringLength(255)]
        public string CommentEn { get; set; }
        [Column("Name_ru")]
        [StringLength(255)]
        public string NameRu { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }

        [InverseProperty("Org")]
        public virtual ICollection<Watchers> Watchers { get; set; }
    }
}
