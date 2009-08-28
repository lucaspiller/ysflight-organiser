using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Ysfo.Core.Addons;

namespace Ysfo.Core.Loaders
{
    /// <summary>
    /// Provides methods for parsing a .lst file.
    /// </summary>
    public static class LstLoader
    {
        /// <summary>
        /// Loads the objects specified in a .lst file.
        /// </summary>
        /// <typeparam name="T">The type of object this .lst file contains.</typeparam>
        /// <param name="ysPath">The path to the base directory of YsFlight.</param>
        /// <param name="lstPath">The relative path to the .lst file, from <paramref name="ysPath"/>.</param>
        /// <returns>A collection of objects.</returns>
        /// <remarks>
        /// If the file specified in lstPath does not exist an empty collection will be returned.
        /// If the entry for an object in the .lst file is invalid (wrong directory seperator)
        /// for the execution platform, it will be converted.
        /// </remarks>
        /// <exception cref="DirectoryNotFoundException">Directory <paramref name="ysPath"/> does not exist.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="ysPath"/> or <paramref name="lstPath"/> is <code>null</code>.</exception>
        public static ICollection<T> Load<T>(String ysPath, String lstPath) where T: Addon, new()
        {
            // get path
            String path = PathHelper.GetFullPath(ysPath, lstPath);

            // initialize collection
            ICollection<T> addons = new List<T>();

            // only load if file exists
            if (File.Exists(path))
            {
                // read from file
                var query =
                    from line in LineReader(path)
                    where line.Length > 0
                    select line;

                // add to collection
                query.ForEach(line =>
                {
                    // convert dir seperators
                    line = PathHelper.ConvertLstEntryToNative(line);

                    // load aircraft
                    T addon = new T {LstEntry = line};

                    try
                    {
                        // load addon
                        addon.Load(ysPath);
                    }
                    catch (InvalidLstEntryException)
                    {
                        // invalid lst entry
                        // TODO: Notify of this somehow
                    }

                    addons.Add(addon);
                });
            }

            return addons;
        }

        private static IEnumerable<String> LineReader(String fileName)
        {
            String line;
            using (var file = File.OpenText(fileName))
            {
                // read each line, ensuring not null (EOF)
                while ((line = file.ReadLine()) != null)
                {
                    // return trimmed line
                    yield return line.Trim();
                }
            }
        }

        /// <summary>
        /// Saves the objects in the collection to the specified .lst file.
        /// </summary>
        /// <typeparam name="T">The type of object contained in the collection.</typeparam>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="lstPath">The relative path to the .lst file, from <paramref name="ysPath"/>.</param>
        /// <param name="addons">The collection of addons to save.</param>
        /// <remarks>
        /// If the file does not exist it will be created, however if the path to the file
        /// does not exist an exception will be thrown.
        /// If the collection of addons is empty an empty file will be written.
        /// </remarks>
        /// <exception cref="DirectoryNotFoundException">Directory <paramref name="ysPath"/> does not exist.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="ysPath"/> or <paramref name="ysPath"/> is <code>null</code>.</exception>
        public static void Save<T>(String ysPath, String lstPath, ICollection<T> addons) where T: Addon, new()
        {
            // get path
            String path = PathHelper.GetFullPath(ysPath, lstPath);

            // open file
            using (var file = new StreamWriter(path))
            {
                // for each addon
                addons.ForEach(addon => file.WriteLine(addon.LstEntry));
            }
        }
    }
}