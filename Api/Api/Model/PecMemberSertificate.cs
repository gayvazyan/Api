using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    public partial class PecMemberSertificate
    {
        [Required]
        [StringLength(16)]
        public string Sertificate { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}
