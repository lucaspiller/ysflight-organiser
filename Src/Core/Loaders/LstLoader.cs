﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Ysfo.Core.Addons;

namespace Ysfo.Core.Loaders
{
    public static class LstLoader
    {
        public static ICollection<T> Load<T>(String ysPath, String lstPath) where T: Addon, new()
        {
            // get path
            String path = GetFullPath(ysPath, lstPath);

            // initialize collection
            ICollection<T> addons = new List<T>();

            // read from file
            var query =
                from line in LineReader(path)
                where line.Length > 0
                select line;

            // add to collection
            query.ForEach(line =>
                              {
                                  // load aircraft
                                  T addon = new T {LstEntry = line};
                                  addon.Load(ysPath);

                                  addons.Add(addon);
                              });

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

            String lstFullPath = Path.Combine(ysPath, lstPath);

            if (!File.Exists(lstFullPath))
            {
                throw new ArgumentException("Invalid lstPath; file `" + lstFullPath + "'does not exist.");
            }

            return lstFullPath;
        }
    }
}