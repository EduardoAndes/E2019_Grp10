namespace Business
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Billing")]
    public partial class Billing
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ReferenceNumber { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Bill { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string DueDate { get; set; }

        public int? TotalConsume { get; set; }

        public decimal? Total { get; set; }
        public int? UserId { get; set; }

        public DateTime? CrDate { get; set; }
    }
}
