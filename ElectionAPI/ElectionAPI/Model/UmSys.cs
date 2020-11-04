using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    [Table("umSys")]
    public partial class UmSys
    {
        [Key]
        public int Id { get; set; }
        public int? WebUpdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChangeDate { get; set; }
        public int? ActiveElection { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChangeDate2 { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ChangeDate3 { get; set; }
    }
}
