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
            return new Loader.AircraftCollection();
        }
    }
}
