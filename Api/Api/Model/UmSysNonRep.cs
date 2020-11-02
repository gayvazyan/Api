using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("umSys_non_rep")]
    public partial class UmSysNonRep
    {
        public int? GridIterator { get; set; }
    }
}
