using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class Regions
    {
        public Regions()
        {
            Communitis = new HashSet<Communitis>();
        }

        [Key]
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
        [Column("Name_en")]
        [StringLength(64)]
        public string NameEn { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }

        [InverseProperty("RegionCodeNavigation")]
        public virtual ICollection<Communitis> Communitis { get; set; }
    }
}
