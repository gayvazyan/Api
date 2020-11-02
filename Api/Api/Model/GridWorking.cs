using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class GridWorking
    {
        [Column("ID")]
        public int Id { get; set; }
        public int? SbDst { get; set; }
    }
}
