using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("city")]
    public partial class City
    {
        [Required]
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("Name_en")]
        [StringLength(64)]
        public string NameEn { get; set; }
        [Column("pr")]
        [StringLength(2)]
        public string Pr { get; set; }
    }
}
