namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ticket
    {
        public int TicketID { get; set; }

        public int BookingID { get; set; }

        public int SeatID { get; set; }

        [Required]
        [StringLength(20)]
        public string TicketCode { get; set; }

        [Required]
        [StringLength(100)]
        public string PassengerName { get; set; }

        [Required]
        [StringLength(20)]
        public string PassengerType { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(20)]
        public string PassportNumber { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        public DateTime? TicketIssueDate { get; set; }

        [StringLength(20)]
        public string TicketStatus { get; set; }

        public decimal BaseFare { get; set; }

        public decimal Taxes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TotalPrice { get; set; }

        public virtual Booking Booking { get; set; }

        public virtual Seat Seat { get; set; }
    }
}
