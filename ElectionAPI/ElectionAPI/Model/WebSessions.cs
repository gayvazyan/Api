using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectionAPI.Model
{
    [Table("WEB_Sessions")]
    public partial class WebSessions
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [Column("Title_en")]
        [StringLength(255)]
        public string TitleEn { get; set; }
        [Column("File_Url")]
        [StringLength(255)]
        public string FileUrl { get; set; }
        [Column("File_Url_en")]
        [StringLength(255)]
        public string FileUrlEn { get; set; }
        [Column("Video_Url")]
        [StringLength(255)]
        public string VideoUrl { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}
