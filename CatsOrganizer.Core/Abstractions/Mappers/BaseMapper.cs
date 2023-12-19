using System.Collections.Generic;
using System.Linq;

namespace CatsOrganizer.Core.Abstractions.Mappers
{
    public abstract class BaseMapper<TFrom, TTo> : IMapper<TFrom, TTo>
    {
        public abstract TTo Map(TFrom source);

        public IEnumerable<TTo> Map(IEnumerable<TFrom> source)
        {
            if (source == null)
            {
                return null;
            }

            return source.Select(x => Map(x));
        }
    }
}
