using System;
using System.Collections.Generic;
using Ysfo.Core.Addons;
using Ysfo.Core.Loaders;

namespace Ysfo.Core.Collections
{
    public class AddonCollection<T> : List<T> where T: Addon, new()
    {
        public string YsPath { get; protected set; }
        public string LstPath { get; protected set; }

        public AddonCollection(String ysPath) : this(ysPath, null)
        {
        }

        public AddonCollection(String ysPath, String lstPath)
        {
            YsPath = ysPath;
            LstPath = lstPath ?? DefaultLstPath();
        }

        public void Load()
        {
            // load
            ICollection<T> addons = LstLoader.Load<T>(YsPath, LstPath);

            // clear and add addons
            Clear();
            AddRange(addons);
        }

        public void Save()
        {
            // save
            LstLoader.Save(YsPath, LstPath, this);
        }

        private static String DefaultLstPath()
        {
            if (typeof(T) == typeof(AircraftAddon))
            {
                return "aircraft/aircraft.lst";
            }
            
            if (typeof(T) == typeof(GroundAddon))
            {
                return "ground/ground.lst";
            }

            if (typeof(T) == typeof(SceneryAddon))
            {
                return "scenery/scenery.lst";
            }
            
            // eek
            throw new ArgumentException("Unknown addon type " + typeof(T).Name);
        }
    }
}