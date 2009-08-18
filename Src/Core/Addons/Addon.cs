using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Addons
{
    public abstract class Addon
    {
        public String Name { get; protected set; }
        public String LstEntry { get; set; }

        public abstract void Load(String ysPath);
    }
}
