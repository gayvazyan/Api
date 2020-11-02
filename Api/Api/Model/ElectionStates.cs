using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class ElectionStates
    {
        public ElectionStates()
        {
            Elections = new HashSet<Elections>();
        }

        [Key]
        public int StateId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }

        [InverseProperty("State")]
        public virtual ICollection<Elections> Elections { get; set; }
    }
}
