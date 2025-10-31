namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aircrafts")]
    public partial class Aircraft
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aircraft()
        {
            Flights = new HashSet<Flight>();
        }

        public int AircraftID { get; set; }

        public int AirlineID { get; set; }

        [Required]
        [StringLength(20)]
        public string AircraftCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public int SeatCapacity { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public virtual Airline Airline { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
