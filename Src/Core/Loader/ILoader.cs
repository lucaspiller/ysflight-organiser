using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Loader
{
    public interface ILoader
    {
        ICollection<Addons.Aircraft> Load();
        void Save(ICollection<Addons.Aircraft> collection);
    }
}
