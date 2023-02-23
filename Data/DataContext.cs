using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using pawcare.Models;
namespace pawcare.Data
{
    public class DataContext : IdentityUserContext<IdentityUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<dog>()
                .HasOne(e => e.idClient)
                .WithMany(e => e.idDog)
                .IsRequired(false);
        }

        public DbSet<dog> Dogs { get; set; } = null!;
        public DbSet<Cliente> Clients { get; set; } = null!;
        public DbSet<race> Races { get; set; } = null!;
        public DbSet<deworming> Dewormings { get; set; } = null!;
        public DbSet<estetic_Dates> EstheticDates { get; set; } = null!;
        public DbSet<medic_Dates> MedicDates { get; set; } = null!;
        public DbSet<medicalRecords> MedicalRecords { get; set; } = null!;
        public DbSet<reminders> Reminders { get; set; } = null!;
        public DbSet<vacinnes> Vacinnes {get; set;} = null!;
    }
}
