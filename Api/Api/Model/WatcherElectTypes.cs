using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("Watcher_Elect_Types")]
    public partial class WatcherElectTypes
    {
        public int TypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("Name_en")]
        [StringLength(255)]
        public string NameEn { get; set; }
        [Column("Name_ru")]
        [StringLength(255)]
        public string NameRu { get; set; }
    }
}
