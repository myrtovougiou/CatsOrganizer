using CatsOrganizer.Core.Abstractions.DataAccess;
using CatsOrganizer.Core.Enums;
using System;

namespace CatsOrganizer.Core.DataAccess
{
    public class Microchip : BaseAppointment
    {
        public ChipPosition Position { get; set; }
        public string Number { get; set; }
        public bool IsMunicipalityDeclared { get; set; }
    }
}
