using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;

namespace Ysfo.Core.Loaders
{
    /// <summary>
    /// Provides methods for parsing a .dat file.
    /// </summary>
    public class DatLoader : IDisposable
    {
        private String _ysPath;
        private String _lstEntry;

        private Dictionary<Regex, String> _results;
        private List<Regex> _regexs;

        /// <summary>
        /// Creates a new addon collection.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="lstEntry">The lst entry for this object.</param>
        /// <remarks>
        /// If <paramref name="lstEntry"/> is invalid (wrong directory seperator)
        /// for the execution platform, it will be converted.
        /// </remarks>
        /// <example>
        /// var loader = new DatLoader(path, entry);
        /// var nameRegex = loader.AddRegex("NAME (.*)");
        /// loader.load();
        /// String name = loader.GetValue(nameRegex);
        /// </example>
        public DatLoader(String ysPath, String lstEntry)
        {
            _ysPath = ysPath;
            _lstEntry = lstEntry;

            _results = new Dictionary<Regex, string>();
            _regexs = new List<Regex>();
        }

        /// <summary>
        /// Adds a regex to the list of regexs to search for.
        /// </summary>
        /// <param name="regex">The Regex object to match.</param>
        public void AddRegex(Regex regex)
        {
            // add to collection
            _regexs.Add(regex);
        }

        /// <summary>
        /// Adds a regex to the list of regexs to search for.
        /// </summary>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>A Regex object for the pattern.</returns>
        /// <remarks>
        /// The return value from this should be passed to GetValue after
        /// Load has been called, to get the value for that regex.
        /// </remarks>
        public Regex AddRegex(String pattern)
        {
            // create
            Regex regex = new Regex(pattern);

            // add to collection
            AddRegex(regex);

            return regex;
        }

        /// <summary>
        /// Gets the value (if any) for the given regex.
        /// </summary>
        /// <param name="regex">The Regex object to get the value for.</param>
        /// <returns>Value of the given regex, or <code>null</code>.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="regex"/>
        /// was not passed to AddRegex before Load was called.</exception>
        public String GetValue(Regex regex)
        {
            // value
            return _results[regex];
        }

        /// <summary>
        /// Loads the dat file, parsing the regular expressions to extract data.
        /// </summary>
        /// <exception cref="DirectoryNotFoundException">Directory ysPath does not exist.</exception>
        /// <exception cref="ArgumentNullException">ysPath or lstPath is <code>null</code>.</exception>
        /// <exception cref="ArgumentException">lstEntry is invalid.</exception>
        /// <exception cref="InvalidOperationException">Load called before AddRegex.</exception>
        public void Load()
        {
            // don't bother if there are no regexs
            if (_regexs.Count == 0)
                throw new InvalidOperationException("Must call AddRegex at least once before calling Load.");

            // get dat file
            String datFile = GetDatFileFromLstEntry(_lstEntry);

            // get dat file path
            datFile = PathHelper.GetFullPath(_ysPath, datFile);

            // open file
            using (var file = File.OpenText(datFile))
            {
                // read each line, ensuring not null (EOF)
                Boolean finished = false;
                String line;
                while ((line = file.ReadLine()) != null)
                {
                    // skip if blank
                    if (line.Length == 0)
                    {
                        continue;
                    }

                    // for each regex
                    _regexs.ForEach(regex =>
                    {
                        // check if matches
                        Match m = regex.Match(line);
                        if (m.Success)
                        {
                            // if so set result
                            _results[regex] = m.Groups[1].Value;

                            // check whether all values are set
                            finished = (_results.Count == _regexs.Count);
                        }
                    });

                    // yes, so exit loop
                    if (finished)
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Parses a LstEntry to return the relative path to the .dat file.
        /// </summary>
        /// <param name="lstEntry">The entry in the .lst file for the object.</param>
        /// <returns>The relative path to the .dat file from the YsFlight base directory.</returns>
        /// <remarks>
        /// If <paramref name="lstEntry"/> is invalid (wrong directory seperator)
        /// for the execution platform, it will be converted.
        /// </remarks>
        /// <exception cref="ArgumentNullException"><paramref name="lstEntry"/> is <code>null</code>.</exception>
        /// <exception cref="ArgumentException"><paramref name="lstEntry"/> is invalid.</exception>
        public static String GetDatFileFromLstEntry(String lstEntry)
        {
            // check not null
            if (lstEntry == null)
            {
                throw new ArgumentNullException("lstEntry");
            }

            // convert lst entry
            lstEntry = PathHelper.ConvertLstEntryToNative(lstEntry);

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

        public void Dispose()
        {
        }
    }
}