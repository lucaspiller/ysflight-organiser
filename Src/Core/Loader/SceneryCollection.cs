using System;

namespace Ysfo.Core
{
    public class SceneryCollection : Internal.AddonCollection<SceneryAddon>
    {
        public SceneryCollection(String ysPath) : base(ysPath)
        {
        }

        public SceneryCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}
