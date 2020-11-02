using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class ElectionDecisions
    {
        [Key]
        public int DecisionId { get; set; }
        public int ElectionId { get; set; }
        public int DistrictId { get; set; }
        [StringLength(32)]
        public string Number { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(128)]
        public string CityName { get; set; }
        [StringLength(1024)]
        public string Comment { get; set; }
        public string Additional { get; set; }
        public bool? ShowWeb { get; set; }
        [Column("CityName_en")]
        [StringLength(128)]
        public string CityNameEn { get; set; }
        [Column("Comment_en")]
        [StringLength(1024)]
        public string CommentEn { get; set; }
        [StringLength(32)]
        public string Number2 { get; set; }
        public int? Type { get; set; }
    }
}
