using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            throw new NotImplementedException();
        }

        public void Save(ICollection<Addons.Aircraft> collection)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
