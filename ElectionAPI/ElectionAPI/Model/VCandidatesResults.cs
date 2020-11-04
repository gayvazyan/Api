using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class VCandidatesResults
    {
        public int ElectionId { get; set; }
        public int CandidateId { get; set; }
        [Column("value")]
        public int? Value { get; set; }
        public int? State { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }
    }
}
