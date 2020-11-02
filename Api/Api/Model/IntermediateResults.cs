using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class IntermediateResults
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        public int SubDistrictId { get; set; }
        public int InfoId { get; set; }
        [Column("value")]
        public int Value { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
