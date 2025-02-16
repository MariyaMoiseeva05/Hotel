namespace Hotel2.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Hotel_room = new HashSet<Hotel_room>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_user { get; set; }

        [Required]
        [StringLength(200)]
        public string full_name { get; set; }

        public int ID_type { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Required]
        [StringLength(50)]
        public string phone_number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hotel_room> Hotel_room { get; set; }

        public virtual UserType UserType { get; set; }
    }
}
