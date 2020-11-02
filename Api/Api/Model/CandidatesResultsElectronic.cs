using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("CandidatesResults_Electronic")]
    public partial class CandidatesResultsElectronic
    {
        public int ElectionId { get; set; }
        public int CandidateId { get; set; }
        [Column("value")]
        public int Value { get; set; }
    }
}
