using System;

namespace Ysfo.Tests.Core.Addons
{
    class MockAddon : Ysfo.Core.Internal.Addon
    {
        public override void Load(string ysPath)
        {
            throw new NotImplementedException();
        }
    }
}
