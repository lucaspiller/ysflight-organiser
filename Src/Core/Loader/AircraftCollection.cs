using System;

namespace Ysfo.Core
{
    public class AircraftCollection : Internal.AddonCollection<Aircraft>
    {
        public AircraftCollection(String ysPath) : base(ysPath)
        {
        }

        public AircraftCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}
