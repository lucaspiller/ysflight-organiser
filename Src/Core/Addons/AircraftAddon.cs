using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Ysfo.Core.Addons;
using Ysfo.Core.Loaders;

namespace Ysfo.Core
{
    public class AircraftAddon : Addon
    {
        public override void Load(String ysPath)
        {
            var regexes = new Dictionary<Regex, DatLoader.StringSetDelegate>
            {
                { new Regex("IDENTIFY \"(.*)\""), delegate(String value) { Name = value; } }
            };

            DatLoader.Load(ysPath, LstEntry, regexes);
        }
    }
}
