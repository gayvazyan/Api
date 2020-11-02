using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class PartieOrPartyPersonsResults2
    {
        [Column("ID")]
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int SubDistrictId { get; set; }
        public int PersonId { get; set; }
        [Column("value")]
        public int Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnterDate { get; set; }
        public int? State { get; set; }
        public int? EnterUser { get; set; }
    }
}
