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
        /// <exception cref="InvalidLstEntryException">The lst entry for this addon is invalid.</exception>
        public override void Load(String ysPath)
        {
            try
            {
                Name = ParseLstEntry(LstEntry);
            }
            catch(ArgumentException innerException)
            {
                // invalid lst entry
                throw new InvalidLstEntryException(null, innerException);
            }
        }

        private static String ParseLstEntry(String lstEntry)
        {
            // split lst
            String[] split = lstEntry.Split(' ');

            // name is first entry in lst file
            if (split.Length > 1)
            {
                // name is first part
                return split[0];
            }

            // uh oh
            throw new ArgumentException("Invalid lstEntry.");
        }
    }
}
