using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("WEB_Notifications")]
    public partial class WebNotifications
    {
        [Key]
        public Guid NotificatinId { get; set; }
        [StringLength(32)]
        public string InNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceivingDate { get; set; }
        [StringLength(128)]
        public string NotifyName { get; set; }
        public int? NotifyType { get; set; }
        [StringLength(512)]
        public string NotifyContent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiscussionDate { get; set; }
        [StringLength(512)]
        public string Annotation { get; set; }
        [StringLength(32)]
        public string OutNumber { get; set; }
        [StringLength(256)]
        public string FileName { get; set; }
        [Column("uID")]
        public int UId { get; set; }
        public int? State { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NotifyDate { get; set; }
        [StringLength(32)]
        public string NotifyNumber { get; set; }
    }
}
