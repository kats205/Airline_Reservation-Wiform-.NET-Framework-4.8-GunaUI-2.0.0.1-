using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AR_Winform.Domain.Entities
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        public virtual DbSet<Aircraft> Aircrafts { get; set; }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<BookingPromotion> BookingPromotions { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Refund> Refunds { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SeatClass> SeatClasses { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aircraft>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Aircraft)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airline>()
                .Property(e => e.AirlineCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Airline>()
                .HasMany(e => e.Aircrafts)
                .WithRequired(e => e.Airline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airport>()
                .Property(e => e.AirportCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Airport>()
                .Property(e => e.IATA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Airport>()
                .HasMany(e => e.Flights)
                .WithRequired(e => e.Airport)
                .HasForeignKey(e => e.FromAirport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Airport>()
                .HasMany(e => e.Flights1)
                .WithRequired(e => e.Airport1)
                .HasForeignKey(e => e.ToAirport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.BookingPromotions)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Booking)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.FromAirport)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.ToAirport)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.Seats)
                .WithRequired(e => e.Flight)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .HasMany(e => e.Refunds)
                .WithRequired(e => e.Payment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Promotion>()
                .Property(e => e.DiscountPercent)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Promotion>()
                .HasMany(e => e.BookingPromotions)
                .WithRequired(e => e.Promotion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeatClass>()
                .Property(e => e.Multiplier)
                .HasPrecision(5, 2);

            modelBuilder.Entity<SeatClass>()
                .HasMany(e => e.Seats)
                .WithRequired(e => e.SeatClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seat>()
                .HasMany(e => e.Tickets)
                .WithRequired(e => e.Seat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ticket>()
                .Property(e => e.TotalPrice)
                .HasPrecision(19, 2);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AuditLogs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Bookings)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Notifications)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
