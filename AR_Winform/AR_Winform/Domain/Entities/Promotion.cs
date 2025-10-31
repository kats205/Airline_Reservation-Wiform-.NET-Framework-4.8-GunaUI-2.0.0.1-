namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Promotion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promotion()
        {
            BookingPromotions = new HashSet<BookingPromotion>();
        }

        [Key]
        public int PromoID { get; set; }

        [Required]
        [StringLength(20)]
        public string PromoCode { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public decimal DiscountPercent { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public int MaxUsage { get; set; }

        public int? UsedCount { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingPromotion> BookingPromotions { get; set; }
    }
}
