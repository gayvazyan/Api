using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class Language
    {
        public Language()
        {
            LanguageResource = new HashSet<LanguageResource>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string DisplayName { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public string FlagIcon { get; set; }

        [InverseProperty("Language")]
        public virtual ICollection<LanguageResource> LanguageResource { get; set; }
    }
}
