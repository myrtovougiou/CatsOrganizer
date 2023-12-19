using CatsOrganizer.Core.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace CatsOrganizer.Core.Extensions.Context
{
    public static class ModelBuilderExtensions
    {
        public static void RegisterCatEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.BirthDate).HasColumnType("Date");

                entity
                    .HasOne(x => x.Vet)
                    .WithMany(x => x.Cats)
                    .HasForeignKey(x => x.VetId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity
                    .HasOne(x => x.Owner)
                    .WithMany(x => x.Cats)
                    .HasForeignKey(x => x.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity
                    .HasOne(x => x.Microchip)
                    .WithOne(x => x.Cat)
                    .HasForeignKey<Microchip>(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasOne(x => x.Sterilization)
                    .WithOne(x => x.Cat)
                    .HasForeignKey<Sterilization>(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasMany(x => x.Appointments)
                    .WithOne(x => x.Cat)
                    .HasForeignKey(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasMany(x => x.BloodTests)
                    .WithOne(x => x.Cat)
                    .HasForeignKey(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasMany(x => x.ParasiteTreatments)
                    .WithOne(x => x.Cat)
                    .HasForeignKey(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasMany(x => x.Surgeries)
                    .WithOne(x => x.Cat)
                    .HasForeignKey(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity
                    .HasMany(x => x.Vaccinations)
                    .WithOne(x => x.Cat)
                    .HasForeignKey(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }

        public static void RegisterVetEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vet>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.HasMany(x => x.Cats)
                    .WithOne(x => x.Vet)
                    .HasForeignKey(x => x.VetId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }

        public static void RegisterOwnerEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.HasMany(x => x.Cats)
                    .WithOne(x => x.Owner)
                    .HasForeignKey(x => x.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }

        public static void RegisterAppointmentEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.Cat)
                    .WithMany(x => x.Appointments)
                    .HasForeignKey(x => x.CatId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }

        public static void RegisterMicrochipEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Microchip>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.Position).HasConversion<int>();

                entity.HasOne(x => x.Cat)
                    .WithOne(x => x.Microchip)
                    .HasForeignKey<Microchip>(x => x.CatId);
            });
        }

        public static void RegisterBloodTestEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodTest>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.BloodResultsDate).HasColumnType("Date");

                entity.HasOne(x => x.Cat)
                    .WithMany(x => x.BloodTests)
                    .HasForeignKey(x => x.CatId);
            });
        }

        public static void RegisterParasiteTreatmentEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParasiteTreatment>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.ParasitesType).HasConversion<int>();

                entity.HasOne(x => x.Cat)
                    .WithMany(x => x.ParasiteTreatments)
                    .HasForeignKey(x => x.CatId);
            });
        }

        public static void RegisterSterilizationEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sterilization>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.Cat)
                    .WithOne(x => x.Sterilization)
                    .HasForeignKey<Sterilization>(x => x.CatId);
            });
        }

        public static void RegisterSurgeryEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Surgery>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.Cat)
                    .WithMany(x => x.Surgeries)
                    .HasForeignKey(x => x.CatId);
            });
        }

        public static void RegisterVaccinationEntity(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vaccination>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.HasOne(x => x.Cat)
                    .WithMany(x => x.Vaccinations)
                    .HasForeignKey(x => x.CatId);
            });
        }
    }
}
