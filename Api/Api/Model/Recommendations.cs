using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class Recommendations
    {
        [Key]
        public int RecommendationId { get; set; }
        [StringLength(32)]
        public string Name { get; set; }
        [Column("UKey")]
        public int? Ukey { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
