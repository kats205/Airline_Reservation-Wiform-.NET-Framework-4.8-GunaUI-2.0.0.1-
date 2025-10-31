namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Seat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Seat()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int SeatID { get; set; }

        public int FlightID { get; set; }

        [Required]
        [StringLength(10)]
        public string SeatNumber { get; set; }

        public int ClassID { get; set; }

        [StringLength(20)]
        public string Status { get; set; }

        public virtual Flight Flight { get; set; }

        public virtual SeatClass SeatClass { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
