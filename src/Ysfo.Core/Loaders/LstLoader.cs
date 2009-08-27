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
        /// <param name="lstPath">The relative path to the .lst file, from ysPath.</param>
        /// <returns>A collection of objects.</returns>
        /// <remarks>
        /// If the file specified in lstPath does not exist an empty collection will be returned.
        /// If the entry for an object in the .lst file is invalid for the execution platform, it will be converted.
        /// </remarks>
        public static ICollection<T> Load<T>(String ysPath, String lstPath) where T: Addon, new()
        {
            // get path
            String path = GetFullPath(ysPath, lstPath);

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
                    line = ConvertToNative(line);

                    // load aircraft
                    T addon = new T {LstEntry = line};
                    addon.Load(ysPath);

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

        private static String GetFullPath(String ysPath, String lstPath)
        {
            if (ysPath == null)
            {
                throw new ArgumentException("ysPath is null.");
            }

            if (lstPath == null)
            {
                throw new ArgumentException("lstPath is null.");
            }

            if (!Directory.Exists(ysPath))
            {
                throw new ArgumentException("Invalid ysPath; directory `" + ysPath + "' does not exist.");
            }

            return Path.Combine(ysPath, lstPath);
        }

        private static String ConvertToNative(String line)
        {
            // on Linux, so convert \ to /
            if (Path.DirectorySeparatorChar == '/')
            {
                return line.Replace(@"\", "/");
            }
            
            // on Windows, so convert / to \
            if (Path.DirectorySeparatorChar == '\\')
            {
                return line.Replace("/", @"\");
            }

            // some arcane platform....
            throw new ArgumentException("Unknown DirectorySeperatorChat `" + Path.DirectorySeparatorChar + "'.");
        }

        /// <summary>
        /// Saves the objects in the collection to the specified .lst file.
        /// </summary>
        /// <typeparam name="T">The type of object contained in the collection.</typeparam>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="lstPath">The relative path to the .lst file, from ysPath.</param>
        /// <param name="addons">The collection of addons to save.</param>
        /// <remarks>
        /// If the file does not exist it will be created, however if the path to the file
        /// does not exist an exception will be thrown.
        /// If the collection of addons is empty an empty file will be written.
        /// </remarks>
        public static void Save<T>(String ysPath, String lstPath, ICollection<T> addons) where T: Addon, new()
        {
            // get path
            String path = GetFullPath(ysPath, lstPath);

            // open file
            using (var file = new StreamWriter(path))
            {
                // for each addon
                addons.ForEach(addon =>
                {
                    // write lstentry to file
                    file.WriteLine(addon.LstEntry);
                });
            }
        }
    }
}