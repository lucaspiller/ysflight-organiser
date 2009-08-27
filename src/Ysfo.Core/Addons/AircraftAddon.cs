using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Ysfo.Core.Addons;
using Ysfo.Core.Loaders;

namespace Ysfo.Core
{
    /// <summary>
    /// Represents an aircraft object used by YsFlight.
    /// </summary>
    public class AircraftAddon : Addon
    {
        /// <summary>
        /// The category of the aircraft. Examples include 'fighter' or 'utility'.
        /// </summary>
        public String Category { get; protected set; }

        /// <summary>
        /// The category of the aircraft, formatted in title case.
        /// </summary>
        public String CategoryPretty { get { return Category.ToTitleCase(); } }

        /// <summary>
        /// Load the details of the aircraft from disk, by parsing the .dat file referred to in the LstEntry.
        /// </summary>
        /// <param name="ysPath">The path to the base directory of YsFlight.</param>
        public override void Load(String ysPath)
        {
            var regexes = new Dictionary<Regex, DatLoader.StringSetDelegate>
            {
                {new Regex("IDENTIFY \"(.*)\""), delegate(String value) { Name = value; }},
                {new Regex("CATEGORY (.*)"), delegate(String value) { Category = value; }}
            };

            DatLoader.Load(ysPath, LstEntry, regexes);
        }
    }
}
