using System;

namespace Ysfo.Core.Collections
{
    /// <summary>
    /// Represents a collection of ground objects used by YsFlight.
    /// </summary>
    public class GroundCollection : AddonCollection<GroundAddon>
    {
        /// <summary>
        /// Creates a new ground object collection, using the default .lst file for ground objects.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        public GroundCollection(String ysPath) : base(ysPath)
        {
        }

        /// <summary>
        /// Creates a new ground object collection.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="lstPath">The relative path to the .lst file, from ysPath.</param>
        public GroundCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}