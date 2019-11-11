namespace Hotel2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service_cost
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service_cost()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int ID { get; set; }

        public int client_code { get; set; }

        public int id_additional_services { get; set; }

        [Column(TypeName = "money")]
        public decimal cost { get; set; }

        public DateTime data { get; set; }

        public virtual Additional_services Additional_services { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
