using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Project_one_EAD
{
    public class Project1Context : DbContext
    {
        public Project1Context(DbContextOptions<Project1Context> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure primary keys, foreign keys, etc.
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID);

            modelBuilder.Entity<Vehicle>()
                .HasKey(v => v.VehicleID);

            modelBuilder.Entity<CheckIn>()
                .HasKey(c => c.CheckInID);

            modelBuilder.Entity<CheckIn>()
                .HasOne(c => c.User)
                .WithMany(u => u.CheckIns)
                .HasForeignKey(c => c.UserID);

            modelBuilder.Entity<CheckIn>()
                .HasOne(c => c.Vehicle)
                .WithMany(v => v.CheckIns)
                .HasForeignKey(c => c.VehicleID);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}

    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

        public ICollection<CheckIn> CheckIns { get; set; }
    }

    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleName { get; set; }
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }

        public ICollection<CheckIn> CheckIns { get; set; }
    }

    public class CheckIn
    {
        public int CheckInID { get; set; }
        public int UserID { get; set; }
        public int VehicleID { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        public User User { get; set; }
        public Vehicle Vehicle { get; set; }
    }

