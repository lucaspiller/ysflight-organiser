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
        public override void Load(String ysPath)
        {
            var regexes = new Dictionary<Regex, DatLoader.StringSetDelegate>
            {
                { new Regex("IDENTIFY (.*)"), delegate(String value) { Name = value; } }
            };

            DatLoader.Load(ysPath, LstEntry, regexes);
        }
    }
}
