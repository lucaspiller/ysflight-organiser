using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Ysfo.Core.Addons
{
    public class Aircraft : Addon
    {
        public override void Load(String ysPath)
        {
            Dictionary<Regex, Loader.DatLoader.StringSetDelegate> regexes = new Dictionary<Regex, Loader.DatLoader.StringSetDelegate>() {
                { new Regex("IDENTIFY \"(.*)\""), delegate(String value) { Name = value; } }
            };

            Loader.DatLoader.Load(ysPath, LstEntry, regexes);
        }
    }
}
