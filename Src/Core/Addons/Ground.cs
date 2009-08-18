using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ysfo.Core
{
    public class Ground : Internal.Addon
    {
        public override void Load(String ysPath)
        {
            var regexes = new Dictionary<Regex, Internal.DatLoader.StringSetDelegate>
            {
                { new Regex("IDENTIFY (.*)"), delegate(String value) { Name = value; } }
            };

            Internal.DatLoader.Load(ysPath, LstEntry, regexes);
        }
    }
}
