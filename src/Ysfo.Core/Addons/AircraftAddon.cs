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
            using (var loader = new DatLoader(ysPath, LstEntry))
            {
                // add regex
                Regex nameRegex = loader.AddRegex("IDENTIFY \"(.*)\"");
                Regex categoryRegex = loader.AddRegex("CATEGORY (.*)");

                // load
                loader.Load();

                // set values
                Name = loader.GetValue(nameRegex);
                Category = loader.GetValue(categoryRegex);
            }
        }
    }
}
