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

        public Loader.AddonCollection<Addons.Aircraft> GetAircraftCollection()
        {
            return GetAircraftCollection(null);
        }

        public Loader.AddonCollection<Addons.Aircraft> GetAircraftCollection(String lstPath)
        {
            Loader.AddonCollection<Addons.Aircraft> collection = new Loader.AddonCollection<Addons.Aircraft>(Path, lstPath);
            collection.Load();

            return collection;
        }
    }
}
