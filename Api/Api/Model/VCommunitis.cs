using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class VCommunitis
    {
        [Required]
        [StringLength(2)]
        public string RegionCode { get; set; }
        [StringLength(64)]
        public string RegionName { get; set; }
        [Required]
        [StringLength(3)]
        public string CommunityCode { get; set; }
        [StringLength(64)]
        public string CommunityName { get; set; }
    }
}
