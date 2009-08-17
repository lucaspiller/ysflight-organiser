using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public static class DatLoader
    {
        public static String GetDatFileFromLstEntry(String lstEntry)
        {
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
