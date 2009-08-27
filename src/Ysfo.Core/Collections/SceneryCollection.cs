using System;

namespace Ysfo.Core.Collections
{
    /// <summary>
    /// Represents a collection of scenery objects (maps) used by YsFlight.
    /// </summary>
    public class SceneryCollection : AddonCollection<SceneryAddon>
    {
        /// <summary>
        /// Creates a new scenery object collection, using the default .lst file for scenery objects.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        public SceneryCollection(String ysPath) : base(ysPath)
        {
        }

        /// <summary>
        /// Creates a new scenery object collection.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="lstPath">The relative path to the .lst file, from ysPath.</param>
        public SceneryCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}