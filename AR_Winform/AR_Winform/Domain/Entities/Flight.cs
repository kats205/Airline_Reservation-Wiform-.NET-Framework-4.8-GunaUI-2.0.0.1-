namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            Seats = new HashSet<Seat>();
        }

        public int FlightID { get; set; }

        [Required]
        [StringLength(20)]
        public string FlightCode { get; set; }

        public int AircraftID { get; set; }

        [Required]
        [StringLength(5)]
        public string FromAirport { get; set; }

        [Required]
        [StringLength(5)]
        public string ToAirport { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public decimal BasePrice { get; set; }

        public virtual Aircraft Aircraft { get; set; }

        public virtual Airport Airport { get; set; }

        public virtual Airport Airport1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
