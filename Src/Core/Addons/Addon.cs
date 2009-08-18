using System;

namespace Ysfo.Core.Internal
{
    public abstract class Addon
    {
        public String Name { get; protected set; }
        public String LstEntry { get; set; }

        public abstract void Load(String ysPath);
    }
}
