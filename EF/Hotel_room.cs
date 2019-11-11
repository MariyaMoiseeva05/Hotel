namespace Hotel2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hotel_room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hotel_room()
        {
            Reservations = new HashSet<Reservation>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_room { get; set; }

        public int room_number { get; set; }

        public int ID_employment { get; set; }

        public int cleaning_status { get; set; }

        public DateTime? arrival_date { get; set; }

        public DateTime? date_of_departure { get; set; }

        public int ID_category { get; set; }

        public int ID_user { get; set; }

        public virtual Condition Condition { get; set; }

        public virtual Employment Employment { get; set; }

        public virtual Room_category Room_category { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
