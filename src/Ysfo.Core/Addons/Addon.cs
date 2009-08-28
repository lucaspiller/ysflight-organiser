using System;

namespace Ysfo.Core.Addons
{
    /// <summary>
    /// Represents an external game object used by YsFlight.
    /// </summary>
    public abstract class Addon
    {
        /// <summary>
        /// The Name of the object.
        /// </summary>
        public String Name { get; protected set; }
        /// <summary>
        /// The Name of the object, formatted in title case.
        /// </summary>
        public String NamePretty { get { return Name.ToTitleCase() ?? "-- Invalid --"; } }

        /// <summary>
        /// The entry for the object in the .lst file.
        /// </summary>
        public String LstEntry { get; set; }

        /// <summary>
        /// Loads the details of the object from disk.
        /// </summary>
        /// <param name="ysPath">The path to the base directory of YsFlight.</param>
        /// <exception cref="InvalidLstEntryException">The lst entry for this addon is invalid.</exception>
        public abstract void Load(String ysPath);
    }
}