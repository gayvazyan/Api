using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class Resource
    {
        public Resource()
        {
            LanguageResource = new HashSet<LanguageResource>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Category { get; set; }
        [Required]
        [StringLength(400)]
        public string Value { get; set; }
        public string Description { get; set; }

        [InverseProperty("Resource")]
        public virtual ICollection<LanguageResource> LanguageResource { get; set; }
    }
}
