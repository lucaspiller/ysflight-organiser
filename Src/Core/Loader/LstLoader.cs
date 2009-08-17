using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public class LstLoader : ILoader
    {
        public LstLoader()
        {

        }

        public LstLoader(String ysPath, String lstPath)
        {

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
