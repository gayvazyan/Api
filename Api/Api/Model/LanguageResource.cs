using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class LanguageResource
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("LanguageID")]
        public int LanguageId { get; set; }
        [Column("ResourceID")]
        public int ResourceId { get; set; }
        [StringLength(400)]
        public string Value { get; set; }

        [ForeignKey(nameof(LanguageId))]
        [InverseProperty("LanguageResource")]
        public virtual Language Language { get; set; }
        [ForeignKey(nameof(ResourceId))]
        [InverseProperty("LanguageResource")]
        public virtual Resource Resource { get; set; }
    }
}
