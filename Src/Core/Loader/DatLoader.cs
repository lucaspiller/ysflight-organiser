using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace Ysfo.Core.Internal
{
    public static class DatLoader
    {
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
                throw new ArgumentException("Invalid ysPath; directory does not exist.");
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
            throw new ArgumentException("No dat file found in lstEntry.");
        }
    }
}
