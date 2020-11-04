using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    [Table("WEB_Announcement")]
    public partial class WebAnnouncement
    {
        [Key]
        [Column("ID")]
        public Guid Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [Column("Title_en")]
        [StringLength(255)]
        public string TitleEn { get; set; }
        [Column(TypeName = "ntext")]
        public string Body { get; set; }
        [Column("Body_en", TypeName = "ntext")]
        public string BodyEn { get; set; }
        [Column("uID")]
        public int UId { get; set; }
        public int? State { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
