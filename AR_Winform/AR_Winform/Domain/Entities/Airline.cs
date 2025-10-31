namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Airline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airline()
        {
            Aircrafts = new HashSet<Aircraft>();
        }

        public int AirlineID { get; set; }

        [Required]
        [StringLength(3)]
        public string AirlineCode { get; set; }

        [Required]
        [StringLength(100)]
        public string AirlineName { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        [StringLength(20)]
        public string Hotline { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aircraft> Aircrafts { get; set; }
    }
}
