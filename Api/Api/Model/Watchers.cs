using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class Watchers
    {
        [Key]
        public int WatcherId { get; set; }
        [StringLength(32)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(32)]
        public string LastName { get; set; }
        [StringLength(9)]
        public string Passport { get; set; }
        [StringLength(10)]
        public string Sertificate { get; set; }
        public int? OrgId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnterDate { get; set; }
        [StringLength(32)]
        public string FirstNameEn { get; set; }
        [StringLength(64)]
        public string MiddleNameEn { get; set; }
        [StringLength(32)]
        public string LastNameEn { get; set; }
        [StringLength(32)]
        public string FirstNameRu { get; set; }
        [StringLength(64)]
        public string MiddleNameRu { get; set; }
        [StringLength(32)]
        public string LastNameRu { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }

        [ForeignKey(nameof(OrgId))]
        [InverseProperty(nameof(Organizations.Watchers))]
        public virtual Organizations Org { get; set; }
    }
}
