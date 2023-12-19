using CatsOrganizer.Core.DataAccess;
using System;

namespace CatsOrganizer.Core.Abstractions.Dtos
{
    public class BaseAppointmentDto : BaseEntityDto
    {
        public DateTime ScheduledDate { get; set; }
        public int Cost { get; set; }
        public Guid CatId { get; set; }
        public Cat Cat { get; set; }
        public bool IsCanceled { get; set; }
    }
}
