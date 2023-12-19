using CatsOrganizer.Core.DataAccess;
using System;

namespace CatsOrganizer.Core.Abstractions.DataAccess
{
    public class BaseAppointment : BaseEntity
    {
        public DateTime ScheduledDate { get; set; }
        public int Cost { get; set; }
        public Guid CatId { get; set; }
        public Cat Cat { get; set; }
        public bool IsCanceled { get; set; }
    }
}
