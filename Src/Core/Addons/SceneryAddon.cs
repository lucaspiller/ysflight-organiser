using System;
using Ysfo.Core.Addons;

namespace Ysfo.Core
{
    /// <summary>
    /// Represents a scenery object (a map) used by YsFlight.
    /// </summary>
    public class SceneryAddon : Addon
    {
        /// <summary>
        /// Loads the details of the map. Currently this just parses the LstEntry to return the map name.
        /// </summary>
        /// <param name="ysPath">The path to the base directory of YsFlight.</param>
        public override void Load(String ysPath)
        {
            ParseLstEntry();
        }

        protected void ParseLstEntry()
        {
            // split lst
            String[] split = LstEntry.Split(' ');

            // name is first entry in lst file
            if (split.Length > 1)
            {
                Name = split[0];
            }
        }
    }
}
