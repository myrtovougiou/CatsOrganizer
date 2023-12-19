using System;

namespace CatsOrganizer.Core.Abstractions.DataAccess
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
