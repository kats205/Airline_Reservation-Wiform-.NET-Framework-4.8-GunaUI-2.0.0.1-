namespace AR_Winform.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Refund
    {
        public int RefundID { get; set; }

        public int PaymentID { get; set; }

        public decimal RefundAmount { get; set; }

        public DateTime? RefundDate { get; set; }

        [StringLength(200)]
        public string Reason { get; set; }

        [StringLength(30)]
        public string Status { get; set; }

        public virtual Payment Payment { get; set; }
    }
}
