using System;
using System.Collections.Generic;
using System.IO;
using Ysfo.Core.Addons;
using Ysfo.Core.Loaders;

namespace Ysfo.Core.Collections
{
    /// <summary>
    /// Represents a collection of addon objects which are used by YsFlight.
    /// </summary>
    /// <typeparam name="T">A type of Addon.</typeparam>
    public class AddonCollection<T> : List<T> where T: Addon, new()
    {
        /// <summary>
        /// The path to the YsFlight base directory.
        /// </summary>
        public string YsPath { get; protected set; }
        
        /// <summary>
        /// The path to the .lst file in used.
        /// </summary>
        public string LstPath { get; protected set; }

        /// <summary>
        /// Creates a new addon collection, using the default .lst file for that type of object.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        public AddonCollection(String ysPath) : this(ysPath, null)
        {
        }

        /// <summary>
        /// Creates a new addon collection.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="lstPath">The relative path to the .lst file, from ysPath.</param>
        public AddonCollection(String ysPath, String lstPath)
        {
            YsPath = ysPath;
            LstPath = lstPath ?? DefaultLstPath();
        }

        /// <summary>
        /// Loads the addons, by parsing the .lst file. If the .lst file does not exist
        /// an empty collection will be returned.
        /// </summary>
        public void Load()
        {
            // load
            ICollection<T> addons = LstLoader.Load<T>(YsPath, LstPath);

            // clear and add addons
            Clear();
            AddRange(addons);
        }

        /// <summary>
        /// Saves the addons to the .lst file. If the .lst file does not exist it
        /// will be created.
        /// </summary>
        public void Save()
        {
            // save
            LstLoader.Save(YsPath, LstPath, this);
        }

        private static String DefaultLstPath()
        {
            if (typeof(T) == typeof(AircraftAddon))
            {
                return Path.Combine("aircraft", "aircraft.lst");
            }
            
            if (typeof(T) == typeof(GroundAddon))
            {
                return Path.Combine("ground", "ground.lst");
            }

            if (typeof(T) == typeof(SceneryAddon))
            {
                return Path.Combine("scenery", "scenery.lst");
            }
            
            // eek
            throw new ArgumentException("Unknown addon type " + typeof(T).Name);
        }
    }
}