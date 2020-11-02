using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("WEB_Cecarx")]
    public partial class WebCecarx
    {
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
    }
}
