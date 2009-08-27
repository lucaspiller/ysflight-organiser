using System;

namespace Ysfo.Core.Collections
{
    /// <summary>
    /// Represents a collection of aircraft used by YsFlight.
    /// </summary>
    public class AircraftCollection : AddonCollection<AircraftAddon>
    {
        /// <summary>
        /// Creates a new aircraft collection, using the default .lst file for aircraft.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        public AircraftCollection(String ysPath) : base(ysPath)
        {
        }

        /// <summary>
        /// Creates a new aircraft collection.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="lstPath">The relative path to the .lst file, from ysPath.</param>
        public AircraftCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}