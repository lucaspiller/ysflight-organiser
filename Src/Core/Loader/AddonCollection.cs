using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public class AddonCollection<T> : List<T> where T: Addons.Addon, new()
    {
        public string YsPath { get; protected set; }
        public string LstPath { get; protected set; }

        public AddonCollection(String ysPath) : this(ysPath, null)
        {
        }

        public AddonCollection(String ysPath, String lstPath)
        {
            YsPath = ysPath;

            if (lstPath == null)
            {
                LstPath = DefaultLstPath();
            }
            else
            {
                LstPath = lstPath;
            }
        }

        public void Load()
        {
            // load aircraft
            ICollection<T> addons = LstLoader.Load<T>(YsPath, LstPath);

            // clear and add addons
            Clear();
            AddRange(addons);
        }

        private String DefaultLstPath()
        {
            if (typeof(T) == typeof(Addons.Aircraft))
            {
                return "aircraft/aircraft.lst";
            }
            else
            {
                throw new ArgumentException("Unknown type " + typeof(T).Name);
            }
        }
    }
}
