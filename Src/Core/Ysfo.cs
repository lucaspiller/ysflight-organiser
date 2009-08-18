using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core
{
    public class Ysfo : IDisposable
    {
        public String Path { get; set; }

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion

        public Loader.AircraftCollection GetAircraftCollection()
        {
            return GetAircraftCollection(null);
        }

        public Loader.AircraftCollection GetAircraftCollection(String lstPath)
        {
            Loader.AircraftCollection collection = new Loader.AircraftCollection(Path, lstPath);
            collection.Load();

            return collection;
        }
    }
}
