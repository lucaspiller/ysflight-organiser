using System;
using Ysfo.Core.Addons;

namespace Ysfo.Core
{
    public class SceneryAddon : Addon
    {
        public override void Load(String ysPath)
        {
            ParseLstEntry();
        }

        protected void ParseLstEntry()
        {
            // split lst
            String[] split = LstEntry.Split(' ');

            // name is first entry in lst file
            if (split.Length > 1)
            {
                Name = split[0];
            }
        }
    }
}
