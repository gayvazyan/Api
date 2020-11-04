using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    public partial class VElections
    {
        public int ElectionId { get; set; }
        public int TypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime SrartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        public int StateId { get; set; }
        public int? LocalDistrictId { get; set; }
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(387)]
        public string ElectName { get; set; }
        [StringLength(255)]
        public string TypeName { get; set; }
    }
}
