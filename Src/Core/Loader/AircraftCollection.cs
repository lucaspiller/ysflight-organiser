using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public class AircraftCollection : List<Addons.Aircraft>
    {
        public const String DefaultLstPath = "aircraft/aircraft.lst";

        public string YsPath { get; protected set; }
        public string LstPath { get; protected set; }

        public AircraftCollection(String ysPath) : this(ysPath, null)
        {
        }

        public AircraftCollection(String ysPath, String lstPath)
        {
            YsPath = ysPath;

            if (lstPath == null)
            {
                LstPath = DefaultLstPath;
            }
            else
            {
                LstPath = lstPath;
            }
        }

        public void Load()
        {
            // load aircraft
            ICollection<Addons.Aircraft> aircraft = LstLoader.Load(YsPath, LstPath);

            // clear and add aircraft
            Clear();
            AddRange(aircraft);
        }
    }
}
