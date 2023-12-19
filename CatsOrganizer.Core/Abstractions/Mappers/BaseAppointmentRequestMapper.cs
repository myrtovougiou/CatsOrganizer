using CatsOrganizer.Core.Abstractions.DataAccess;
using CatsOrganizer.Core.Abstractions.Requests;

namespace CatsOrganizer.Core.Abstractions.Mappers
{
    public abstract class BaseAppointmentRequestMapper<TFrom, TTo> : BaseMapper<TFrom, TTo>
        where TFrom : BaseAppointment
        where TTo : BaseAppointmentRequest, new()
    {
        public override TTo Map(TFrom source)
        {
            if (source == null)
            {
                return null;
            }

            return new TTo
            {
                Id = source.Id,
                ScheduledDate = source.ScheduledDate,
                CatId = source.CatId,
                IsCanceled = source.IsCanceled,
                Cost = source.Cost,
                Cat = source.Cat
            };
        }
    }
}
