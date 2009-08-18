using System;

namespace Ysfo.Core.Collections
{
    public class SceneryCollection : AddonCollection<SceneryAddon>
    {
        public SceneryCollection(String ysPath) : base(ysPath)
        {
        }

        public SceneryCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}