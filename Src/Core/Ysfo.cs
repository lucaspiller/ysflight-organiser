using System;
using System.IO;
using Ysfo.Core.Collections;

namespace Ysfo.Core
{
    /// <summary>
    /// Performs operations on the data files of a YsFlight installation.
    /// </summary>
    public class Ysfo : IDisposable
    {
        /// <summary>
        /// The path to the base directory of YsFlight.
        /// </summary>
        public String Path { get; set; }

        public void Dispose()
        {
        }

        /// <summary>
        /// Checks whether Path is a valid ysflight directory.
        /// </summary>
        /// <returns>true is Path is valid.</returns>
        public Boolean IsPathValid()
        {
            // check path is not null
            if (Path == null)
            {
                return false;
            }

            // check directory
            if (!Directory.Exists(Path))
            {
                return false;
            }

            String windowsYsFlight = "ysflight.exe";
            String linuxYsFlight = "ysflight";

            // check ysflight exectutable
            if (!File.Exists(System.IO.Path.Combine(Path, windowsYsFlight)) && !File.Exists(System.IO.Path.Combine(Path, linuxYsFlight)))
            {
                return false;
            }

            // yay
            return true;
        }

        /// <summary>
        /// Returns a collection of all aircraft specified in the default .lst file.
        /// </summary>
        public AircraftCollection GetAircraftCollection()
        {
            return GetAircraftCollection(null);
        }

        /// <summary>
        /// Returns a collection of all aircraft specified in lstPath.
        /// </summary>
        /// <param name="lstPath">The relative path to the .lst file, from Path.</param>
        public AircraftCollection GetAircraftCollection(String lstPath)
        {
            AircraftCollection collection = new AircraftCollection(Path, lstPath);
            collection.Load();

            return collection;
        }

        /// <summary>
        /// Returns a collection of all ground objects specified in the default .lst file.
        /// </summary>
        public GroundCollection GetGroundCollection()
        {
            return GetGroundCollection(null);
        }

        /// <summary>
        /// Returns a collection of all ground objects specified in lstPath.
        /// </summary>
        /// <param name="lstPath">The relative path to the .lst file, from Path.</param>
        public GroundCollection GetGroundCollection(String lstPath)
        {
            GroundCollection collection = new GroundCollection(Path, lstPath);
            collection.Load();

            return collection;
        }

        /// <summary>
        /// Returns a collection of all scenery objects (maps) specified in the default .lst file.
        /// </summary>
        public SceneryCollection GetSceneryCollection()
        {
            return GetSceneryCollection(null);
        }

        /// <summary>
        /// Returns a collection of all scenery objects (maps) specified in lstPath.
        /// </summary>
        /// <param name="lstPath">The relative path to the .lst file, from Path.</param>
        public SceneryCollection GetSceneryCollection(String lstPath)
        {
            SceneryCollection collection = new SceneryCollection(Path, lstPath);
            collection.Load();

            return collection;
        }
    }
}
