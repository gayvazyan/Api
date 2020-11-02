using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("Table_1")]
    public partial class Table1
    {
        [Key]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(10)]
        public string Name { get; set; }
    }
}
