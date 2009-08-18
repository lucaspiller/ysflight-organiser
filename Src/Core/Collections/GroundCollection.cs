using System;

namespace Ysfo.Core.Collections
{
    public class GroundCollection : AddonCollection<GroundAddon>
    {
        public GroundCollection(String ysPath) : base(ysPath)
        {
        }

        public GroundCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}