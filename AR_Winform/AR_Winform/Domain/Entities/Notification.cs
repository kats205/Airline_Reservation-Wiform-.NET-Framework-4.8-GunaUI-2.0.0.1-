namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notification
    {
        public int NotificationID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Message { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public DateTime? CreatedAt { get; set; }

        public bool? IsRead { get; set; }

        public virtual User User { get; set; }
    }
}
