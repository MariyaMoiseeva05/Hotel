namespace BLL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DAL;

    public partial class HotelContext2 : DbContext
    {
        public HotelContext2()
            : base("name=HotelContext")
        {
        }

        public virtual DbSet<Additional_services> Additional_services { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Condition> Conditions { get; set; }
        public virtual DbSet<Cost> Costs { get; set; }
        public virtual DbSet<Employment> Employments { get; set; }
        public virtual DbSet<Hotel_room> Hotel_room { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Reservation_Status> Reservation_Status { get; set; }
        public virtual DbSet<Room_category> Room_category { get; set; }
        public virtual DbSet<Service_cost> Service_cost { get; set; }
        public virtual DbSet<Tariff> Tariffs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Additional_services>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Additional_services>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Additional_services>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Additional_services>()
                .HasMany(e => e.Service_cost)
                .WithRequired(e => e.Additional_services)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.pasport_data)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Condition>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Condition>()
                .HasMany(e => e.Hotel_room)
                .WithRequired(e => e.Condition)
                .HasForeignKey(e => e.cleaning_status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cost>()
                .Property(e => e.cost1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Employment>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Employment>()
                .HasMany(e => e.Hotel_room)
                .WithRequired(e => e.Employment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel_room>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Hotel_room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.Costs)
                .WithRequired(e => e.Reservation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation_Status>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation_Status>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Reservation_Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room_category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Room_category>()
                .Property(e => e.equipment)
                .IsUnicode(false);

            modelBuilder.Entity<Room_category>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Room_category>()
                .HasMany(e => e.Hotel_room)
                .WithRequired(e => e.Room_category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service_cost>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Service_cost>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Service_cost)
                .HasForeignKey(e => e.ID_service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tariff>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Tariff>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Tariff>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Tariff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tariff>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Tariff)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.full_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Hotel_room)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserType>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<UserType>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserType)
                .WillCascadeOnDelete(false);
        }
    }
}
