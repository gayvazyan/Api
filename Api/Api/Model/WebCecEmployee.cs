using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("WEB_CecEmployee")]
    public partial class WebCecEmployee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("Name_en")]
        [StringLength(50)]
        public string NameEn { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [Column("LastName_en")]
        [StringLength(50)]
        public string LastNameEn { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Status { get; set; }
        [Required]
        [Column("Status_en", TypeName = "ntext")]
        public string StatusEn { get; set; }
        [Required]
        [StringLength(150)]
        public string Delegate { get; set; }
        [Required]
        [Column("Delegate_en")]
        [StringLength(150)]
        public string DelegateEn { get; set; }
        [Required]
        [StringLength(150)]
        public string Address { get; set; }
        [Required]
        [Column("Address_en")]
        [StringLength(150)]
        public string AddressEn { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Desc { get; set; }
        [Required]
        [Column("Desc_en", TypeName = "ntext")]
        public string DescEn { get; set; }
        public int? Type { get; set; }
        [Column("ImgURL")]
        [StringLength(50)]
        public string ImgUrl { get; set; }
        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
        public int? UserId { get; set; }
        public int? PosOrder { get; set; }
        public Guid CecEmployId { get; set; }
    }
}
