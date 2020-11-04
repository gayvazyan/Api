using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class CandidatesResults2
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int CandidateId { get; set; }
        public int SubDistrictId { get; set; }
        [Column("value")]
        public int Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EnterDate { get; set; }
        public int? State { get; set; }
        public int? EnterUser { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
