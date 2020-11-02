using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class Commissions
    {
        [Key]
        public int CommissionId { get; set; }
        [StringLength(2)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
