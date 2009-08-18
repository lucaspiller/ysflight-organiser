using System;

namespace Ysfo.Core.Addons
{
    public abstract class Addon
    {
        public String Name { get; protected set; }
        public String LstEntry { get; set; }

        public abstract void Load(String ysPath);

        public override string ToString()
        {
            return Name ?? "-- Addon --";
        }
    }
}