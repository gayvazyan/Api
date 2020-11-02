using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("WEB_Cec")]
    public partial class WebCec
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Required]
        [Column(TypeName = "ntext")]
        public string Desc { get; set; }
        [Column("Desc_en", TypeName = "ntext")]
        public string DescEn { get; set; }
        [StringLength(255)]
        public string File { get; set; }
        [Column("File_en")]
        [StringLength(255)]
        public string FileEn { get; set; }
        [StringLength(8)]
        public string Number { get; set; }
        [Column("DecisionID")]
        public Guid? DecisionId { get; set; }
    }
}
