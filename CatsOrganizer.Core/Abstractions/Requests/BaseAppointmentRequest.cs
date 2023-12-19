using CatsOrganizer.Core.DataAccess;
using System;


namespace CatsOrganizer.Core.Abstractions.Requests
{
    public class BaseAppointmentRequest
    {
        public Guid Id { get; set; }
        public DateTime ScheduledDate { get; set; }
        public int Cost { get; set; }
        public Guid CatId { get; set; }
        public Cat Cat { get; set; }
        public bool IsCanceled { get; set; }
    }
}
