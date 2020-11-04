using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class CandidatePersons
    {
        [Key]
        public int PersonId { get; set; }
        public int CandidateId { get; set; }
        [StringLength(32)]
        public string FirstName { get; set; }
        [StringLength(64)]
        public string MiddleName { get; set; }
        [StringLength(32)]
        public string LastName { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(128)]
        public string Address { get; set; }
        public bool? MaleFemale { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Birthdate { get; set; }
        [Column("PN")]
        [StringLength(50)]
        public string Pn { get; set; }
        [StringLength(16)]
        public string Passport { get; set; }
        public int? WorkType { get; set; }
        [StringLength(64)]
        public string WorkPosition { get; set; }
        [StringLength(128)]
        public string WorkAddress { get; set; }
        public int? OrgId { get; set; }
        public int? RecOrgId { get; set; }
        [Column(TypeName = "ntext")]
        public string Comment { get; set; }
        [Column("Comment_en", TypeName = "ntext")]
        public string CommentEn { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        [Column("FirstName_en")]
        [StringLength(32)]
        public string FirstNameEn { get; set; }
        [Column("MiddleName_en")]
        [StringLength(64)]
        public string MiddleNameEn { get; set; }
        [Column("LastName_en")]
        [StringLength(32)]
        public string LastNameEn { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }

        [ForeignKey(nameof(CandidateId))]
        [InverseProperty(nameof(Candidates.CandidatePersons))]
        public virtual Candidates Candidate { get; set; }
    }
}
