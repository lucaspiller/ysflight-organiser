using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public class AircraftCollection : List<Addons.Aircraft>
    {
        protected String _ysPath;

        public AircraftCollection(String ysPath)
        {
            _ysPath = ysPath;
        }
    }
}
