using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.Abstractions.Repositories;
using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Context;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Dtos;
using CatsOrganizer.Core.Mappers;
using CatsOrganizer.Core.Repositories;
using CatsOrganizer.Core.Requests;
using CatsOrganizer.Core.Services;
using CatsOrganizer.Core.Validators;
using FluentValidation;

namespace CatsOrganizer
{
    public static class RegistrationExtensions
    {
        public static void RegisterMappers(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IMapper<VetRequest, Vet>, VetMapper>();
            builder.Services.AddScoped<IMapper<Vet, VetDto>, VetDtoMapper>();
            builder.Services.AddScoped<IMapper<Vet, VetRequest>, VetRequestMapper>();

            builder.Services.AddScoped<IMapper<CatRequest, Cat>, CatMapper>();
            builder.Services.AddScoped<IMapper<Cat, CatDto>, CatDtoMapper>();
            builder.Services.AddScoped<IMapper<Cat, CatRequest>, CatRequestMapper>();

            builder.Services.AddScoped<IMapper<OwnerRequest, Owner>, OwnerMapper>();
            builder.Services.AddScoped<IMapper<Owner, OwnerDto>, OwnerDtoMapper>();
            builder.Services.AddScoped<IMapper<Owner, OwnerRequest>, OwnerRequestMapper>();

            builder.Services.AddScoped<IMapper<AppointmentRequest, Appointment>, AppointmentMapper>();
            builder.Services.AddScoped<IMapper<Appointment, AppointmentDto>, AppointmentDtoMapper>();
            builder.Services.AddScoped<IMapper<Appointment, AppointmentRequest>, AppointmentRequestMapper>();

            builder.Services.AddScoped<IMapper<BloodTestRequest, BloodTest>, BloodTestMapper>();
            builder.Services.AddScoped<IMapper<BloodTest, BloodTestDto>, BloodTestDtoMapper>();
            builder.Services.AddScoped<IMapper<BloodTest, BloodTestRequest>, BloodTestRequestMapper>();

            builder.Services.AddScoped<IMapper<VaccinationRequest, Vaccination>, VaccinationMapper>();
            builder.Services.AddScoped<IMapper<Vaccination, VaccinationDto>, VaccinationDtoMapper>();
            builder.Services.AddScoped<IMapper<Vaccination, VaccinationRequest>, VaccinationRequestMapper>();

            builder.Services.AddScoped<IMapper<SurgeryRequest, Surgery>, SurgeryMapper>();
            builder.Services.AddScoped<IMapper<Surgery, SurgeryDto>, SurgeryDtoMapper>();
            builder.Services.AddScoped<IMapper<Surgery, SurgeryRequest>, SurgeryRequestMapper>();

            builder.Services.AddScoped<IMapper<ParasiteTreatmentRequest, ParasiteTreatment>, ParasiteTreatmentMapper>();
            builder.Services.AddScoped<IMapper<ParasiteTreatment, ParasiteTreatmentDto>, ParasiteTreatmentDtoMapper>();
            builder.Services.AddScoped<IMapper<ParasiteTreatment, ParasiteTreatmentRequest>, ParasiteTreatmentRequestMapper>();

            builder.Services.AddScoped<IMapper<MicrochipRequest, Microchip>, MicrochipMapper>();
            builder.Services.AddScoped<IMapper<Microchip, MicrochipDto>, MicrochipDtoMapper>();
            builder.Services.AddScoped<IMapper<Microchip, MicrochipRequest>, MicrochipRequestMapper>();

            builder.Services.AddScoped<IMapper<SterilizationRequest, Sterilization>, SterilizationMapper>();
            builder.Services.AddScoped<IMapper<Sterilization, SterilizationDto>, SterilizationDtoMapper>();
            builder.Services.AddScoped<IMapper<Sterilization, SterilizationRequest>, SterilizationRequestMapper>();
        }

        public static void RegisterValidators(this WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IValidator<Vet>, VetValidator>();
            builder.Services.AddTransient<IValidator<Cat>, CatValidator>();
            builder.Services.AddTransient<IValidator<Owner>, OwnerValidator>();
            builder.Services.AddTransient<IValidator<Appointment>, AppointmentValidator>();
            builder.Services.AddTransient<IValidator<ParasiteTreatment>, ParasiteTreatmentValidator>();
            builder.Services.AddTransient<IValidator<Sterilization>, SterilizationValidator>();
            builder.Services.AddTransient<IValidator<Vaccination>, VaccinationValidator>();
            builder.Services.AddTransient<IValidator<Microchip>, MicrochipValidator>();
            builder.Services.AddTransient<IValidator<Surgery>, SurgeryValidator>();
            builder.Services.AddTransient<IValidator<BloodTest>, BloodTestValidator>();
        }

        public static void RegisterRepositories(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IBaseEntityRepository<Vet>, VetRepository>();
            builder.Services.AddScoped<IBaseEntityRepository<Cat>, CatRepository>();
            builder.Services.AddScoped<IBaseEntityRepository<Owner>, OwnerRepository>();
            builder.Services.AddScoped<IBaseAppointmentRepository<BloodTest>, BloodTestRepository>();
            builder.Services.AddScoped<IBaseAppointmentRepository<ParasiteTreatment>, ParasiteTreatmentRepository>();
            builder.Services.AddScoped<IBaseAppointmentRepository<Vaccination>, VaccinationRepository>();
            builder.Services.AddScoped<IBaseAppointmentRepository<Sterilization>, SterilizationRepository>();
            builder.Services.AddScoped<IBaseAppointmentRepository<Surgery>, SurgeryRepository>();
            builder.Services.AddScoped<IBaseAppointmentRepository<Appointment>, AppointmentRepository>();
            builder.Services.AddScoped<IBaseAppointmentRepository<Microchip>, MicrochipRepository>();
            builder.Services.AddScoped<IUnitOfWork<CatDbContext>, UnitOfWork<CatDbContext>>();
        }

        public static void RegisterServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IVetService, VetService>();
            builder.Services.AddScoped<IOwnerService, OwnerService>();
            builder.Services.AddScoped<ICatService, CatService>();
            builder.Services.AddScoped<IBloodTestService, BloodTestService>();
            builder.Services.AddScoped<ISurgeryService, SurgeryService>();
            builder.Services.AddScoped<IVaccinationService, VaccinationService>();
            builder.Services.AddScoped<ISterilizationService, SterilizationService>();
            builder.Services.AddScoped<IParasiteTreatmentService, ParasiteTreatmentService>();
            builder.Services.AddScoped<IMicrochipService, MicrochipService>();
            builder.Services.AddScoped<IAppointmentService, AppointmentService>();
        }
    }
}
