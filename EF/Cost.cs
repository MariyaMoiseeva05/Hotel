namespace Hotel2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cost")]
    public partial class Cost
    {
        [Key]
        public int ID_cost { get; set; }

        [Column("cost", TypeName = "money")]
        public decimal cost1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int reservation_code { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
