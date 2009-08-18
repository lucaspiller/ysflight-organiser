using System;

namespace Ysfo.Core
{
    public class GroundCollection : Internal.AddonCollection<Ground>
    {
        public GroundCollection(String ysPath) : base(ysPath)
        {
        }

        public GroundCollection(String ysPath, String lstPath) : base(ysPath, lstPath)
        {
        }
    }
}
