using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("WEB_News")]
    public partial class WebNews
    {
        [Key]
        [Column("NewsID")]
        public int NewsId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NewsDate { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [Column("Title_en")]
        [StringLength(255)]
        public string TitleEn { get; set; }
        [Column(TypeName = "ntext")]
        public string Body { get; set; }
        [Column("Body_en", TypeName = "ntext")]
        public string BodyEn { get; set; }
        [Column("ID")]
        public Guid? Id { get; set; }
        [Column("msrepl_tran_version")]
        public Guid MsreplTranVersion { get; set; }
    }
}
