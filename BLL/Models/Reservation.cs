namespace BLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            Costs = new HashSet<Cost>();
        }

        [Key]
        public int reservation_code { get; set; }

        public DateTime arrival_dates { get; set; }

        public DateTime dates_of_departure { get; set; }

        public int client_code { get; set; }

        public int ID_tariff { get; set; }

        public int ID_room { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public int reservation_agent { get; set; }

        [Column(TypeName = "money")]
        public decimal cost { get; set; }

        public int ID_service { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cost> Costs { get; set; }

        public virtual Hotel_room Hotel_room { get; set; }

        public virtual Reservation_Status Reservation_Status { get; set; }

        public virtual Service_cost Service_cost { get; set; }

        public virtual Tariff Tariff { get; set; }
    }
}
