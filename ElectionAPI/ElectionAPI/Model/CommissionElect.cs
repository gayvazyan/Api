using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class CommissionElect
    {
        [Key]
        public int CommissionElectId { get; set; }
        public int? CecEmployeeId { get; set; }
        public int? PersonId { get; set; }
        public int? Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        public bool? IsValide { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
