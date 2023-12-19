using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Extensions.Context;
using Microsoft.EntityFrameworkCore;

namespace CatsOrganizer.Core.Context
{
    public class CatDbContext : DbContext
    {
        public CatDbContext(DbContextOptions<CatDbContext> options) : base(options) 
        { }

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<BloodTest> BloodTests { get; set; }
        public DbSet<Vaccination> Vaccinations { get; set; }
        public DbSet<Surgery> Surgeries { get; set; }
        public DbSet<Sterilization> Sterilizations { get; set; }
        public DbSet<Microchip> Microchips { get; set; }
        public DbSet<ParasiteTreatment> ParasiteTreatments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterCatEntity();
            modelBuilder.RegisterVetEntity();
            modelBuilder.RegisterOwnerEntity();
            modelBuilder.RegisterParasiteTreatmentEntity();
            modelBuilder.RegisterSterilizationEntity();
            modelBuilder.RegisterSurgeryEntity();
            modelBuilder.RegisterAppointmentEntity();
            modelBuilder.RegisterBloodTestEntity();
            modelBuilder.RegisterVaccinationEntity();
            modelBuilder.RegisterMicrochipEntity();
        }
    }
}
