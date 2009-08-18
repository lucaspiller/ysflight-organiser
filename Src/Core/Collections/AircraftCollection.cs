using System;

namespace Ysfo.Core.Collections
{
    public class AircraftCollection : AddonCollection<AircraftAddon>
    {
        public AircraftCollection(String ysPath) : base(ysPath)
        {
        }

        public AircraftCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}