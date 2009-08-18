using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Ysfo.Core
{
    public class Aircraft : Internal.Addon
    {
        public override void Load(String ysPath)
        {
            Dictionary<Regex, Internal.DatLoader.StringSetDelegate> regexes = new Dictionary<Regex, Internal.DatLoader.StringSetDelegate>() {
                { new Regex("IDENTIFY \"(.*)\""), delegate(String value) { Name = value; } }
            };

            Internal.DatLoader.Load(ysPath, LstEntry, regexes);
        }
    }
}
