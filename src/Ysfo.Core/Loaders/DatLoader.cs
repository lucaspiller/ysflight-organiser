using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Ysfo.Core.Loaders
{
    /// <summary>
    /// Provides methods for parsing a .dat file.
    /// </summary>
    public static class DatLoader
    {
        /// <summary>
        /// Loads the details of a .dat file.
        /// </summary>
        /// <param name="ysPath">The path to the ysFlight base directory.</param>
        /// <param name="lstEntry">The lst entry for this object.</param>
        /// <param name="regexes">A list of regular expressions to search for, and callbacks to return the result to.</param>
        public static void Load(String ysPath, String lstEntry, Dictionary<Regex, StringSetDelegate> regexes)
        {
            // get dat file
            String datFile = GetDatFileFromLstEntry(lstEntry);

            // check ysPath
            if (ysPath == null)
            {
                throw new ArgumentException("ysPath is null.");
            }

            if (!Directory.Exists(ysPath))
            {
                throw new ArgumentException("Invalid ysPath; directory `" + ysPath + "' does not exist.");
            }

            // combine dat file with base dir to get full path
            datFile = Path.GetFullPath(Path.Combine(ysPath, datFile));

            // open file
            using (var file = File.OpenText(datFile))
            {
                // read each line, ensuring not null (EOF)
                String line;
                while ((line = file.ReadLine()) != null)
                {
                    // for each regex
                    regexes.Keys.ForEach(r =>
                                             {
                                                 // check if matches
                                                 Match m = r.Match(line);
                                                 if (m.Success)
                                                 {
                                                     // if so call delegate with result
                                                     regexes[r](m.Groups[1].Value);
                                                 }
                                             });
                }
            }
        }

        public delegate void StringSetDelegate(String value);

        /// <summary>
        /// Parses a LstEntry to return the relative path to the .dat file.
        /// </summary>
        /// <param name="lstEntry">The entry in the .lst file for the object.</param>
        /// <returns>The relative path to the .dat file from the YsFlight base directory.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when the .dat file cannot be detected in
        /// the given lstEntry. See message for further details.
        /// </exception>
        public static String GetDatFileFromLstEntry(String lstEntry)
        {
            if (lstEntry == null)
            {
                // no match
                throw new ArgumentException("lstEntry is null.");
            }

            // split lst
            String[] split = lstEntry.Split(' ');

            // loop through parts
            foreach (String part in split)
            {
                // look for match
                if (part.ToLower().Contains(".dat"))
                {
                    return part;
                }
            }

            // no match
            throw new ArgumentException("No dat file found in lstEntry `" + lstEntry + "'.");
        }
    }
}