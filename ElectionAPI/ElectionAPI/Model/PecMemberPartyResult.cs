using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class PecMemberPartyResult
    {
        [Key]
        public int ResultId { get; set; }
        public int? PartyId { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        public int? Mandate { get; set; }
        public double? Rest { get; set; }
        public int? Total { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ElectionDate { get; set; }
        public bool? IsQueue { get; set; }
    }
}
