namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AuditLog
    {
        [Key]
        public int LogID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(200)]
        public string Action { get; set; }

        [Required]
        [StringLength(100)]
        public string Entity { get; set; }

        [StringLength(50)]
        public string EntityID { get; set; }

        public DateTime? Timestamp { get; set; }

        public virtual User User { get; set; }
    }
}
