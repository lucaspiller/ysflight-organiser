using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ysfo.Core.Loader
{
    public class LstLoader : ILoader
    {
        public String YsPath { get; set; }
        public String LstPath { get; set; }

        public LstLoader() : this(null, null)
        {
        }

        public LstLoader(String ysPath, String lstPath)
        {
            YsPath = ysPath;
            LstPath = lstPath;
        }

        #region ILoader Members

        public ICollection<Addons.Aircraft> Load()
        {
            // get path
            String path = GetFullPath();

            // initialize collection
            ICollection<Addons.Aircraft> aircraft = new List<Addons.Aircraft>();

            // read from file
            var query =
                from line in LineReader(path)
                where line.Length > 0
                select line;

            // add to collection
            query.ForEach(line =>
            {
                Addons.Aircraft addon = new Addons.Aircraft(line);

                aircraft.Add(addon);
            });

            return aircraft;
        }

        public void Save(ICollection<Addons.Aircraft> collection)
        {
            throw new NotImplementedException();
        }

        #endregion

        protected static IEnumerable<String> LineReader(String fileName)
        {
            String line;
            using (var file = System.IO.File.OpenText(fileName))
            {
                // read each line, ensuring not null (EOF)
                while ((line = file.ReadLine()) != null)
                {
                    // return trimmed line
                    yield return line.Trim();
                }
            }
        }

        protected String GetFullPath()
        {
            if (YsPath == null)
            {
                throw new ArgumentException("YsPath is null; set before calling Load or Save methods.");
            }

            if (LstPath == null)
            {
                throw new ArgumentException("LstPath is null; set before calling Load or Save methods.");
            }

            if (!Directory.Exists(YsPath))
            {
                throw new ArgumentException("Invalid YsPath; directory does not exist.");
            }

            String lstFullPath = Path.Combine(YsPath, LstPath);

            if (!File.Exists(lstFullPath))
            {
                throw new ArgumentException("Invalid LstPath; file does not exist.");
            }

            return lstFullPath;
        }
    }
}
