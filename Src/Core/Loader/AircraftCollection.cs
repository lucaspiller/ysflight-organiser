using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public class AircraftCollection : AddonCollection<Addons.Aircraft>
    {
        public AircraftCollection(String ysPath) : base(ysPath)
        {
        }

        public AircraftCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}
