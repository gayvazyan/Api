using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class ElectTypeAccess
    {
        [Key]
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? ModuleId { get; set; }
        public int? OffsetFrom { get; set; }
        public int? OffsetTo { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
