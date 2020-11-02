using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("ElectiveResults_Electronic")]
    public partial class ElectiveResultsElectronic
    {
        public int ElectionId { get; set; }
        public int CountOfBody { get; set; }
        public int BodyCount { get; set; }
        public int NoElecCards { get; set; }
    }
}
