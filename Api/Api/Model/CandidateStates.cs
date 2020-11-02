using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class CandidateStates
    {
        [Key]
        public int StateId { get; set; }
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
