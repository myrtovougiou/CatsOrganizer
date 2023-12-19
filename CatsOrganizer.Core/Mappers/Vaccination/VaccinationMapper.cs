﻿using CatsOrganizer.Core.Abstractions.Mappers;
using CatsOrganizer.Core.DataAccess;
using CatsOrganizer.Core.Requests;

namespace CatsOrganizer.Core.Mappers
{
    public class VaccinationMapper : BaseAppointmentMapper<VaccinationRequest, Vaccination>
    {
        public override Vaccination Map(VaccinationRequest source)
        {
            if (source == null)
            {
                return null;
            }

            var result = base.Map(source);

            result.VaccineManufacturer = source.VaccineManufacturer;
            result.VaccineName = source.VaccineName;
            result.Disease = source.Disease;
            result.CatWeight = source.CatWeight;

            return result;
        }
    }
}
