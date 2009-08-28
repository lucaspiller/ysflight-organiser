using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Ysfo.Core.Addons;
using Ysfo.Core.Loaders;

namespace Ysfo.Core
{
    /// <summary>
    /// Represents a ground object (any item which can appear on a map) used by YsFlight.
    /// </summary>
    public class GroundAddon : Addon
    {
        /// <summary>
        /// Loads the details of ground object from disk, by parsing the .dat file referred to in the LstEntry.
        /// </summary>
        /// <param name="ysPath">The path to the base directory of YsFlight.</param>
        /// <exception cref="InvalidLstEntryException">The lst entry for this addon is invalid.</exception>
        public override void Load(String ysPath)
        {
            try
            {
                using (var loader = new DatLoader(ysPath, LstEntry))
                {
                    // add regex
                    Regex nameRegex = loader.AddRegex("IDENTIFY (.*)");

                    // load
                    loader.Load();

                    // set values
                    Name = loader.GetValue(nameRegex);
                }
            }
            catch(ArgumentException innerException)
            {
                // invalid lst entry
                throw new InvalidLstEntryException(null, innerException);
            }
        }
    }
}
