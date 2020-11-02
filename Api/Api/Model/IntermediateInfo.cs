using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class IntermediateInfo
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int ElectionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeKey { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
