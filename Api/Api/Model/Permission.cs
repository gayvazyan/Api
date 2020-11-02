using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class Permission
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(200)]
        public string Category { get; set; }
        [Required]
        [StringLength(100)]
        public string ClaimType { get; set; }
        [Required]
        [StringLength(100)]
        public string ClaimValue { get; set; }
        public string Description { get; set; }
    }
}
