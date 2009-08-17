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
            String path = GetFullPath();

            return null;
        }

        public void Save(ICollection<Addons.Aircraft> collection)
        {
            throw new NotImplementedException();
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

        #endregion
    }
}
