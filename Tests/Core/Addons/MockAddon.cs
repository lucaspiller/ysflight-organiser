using System;
using Ysfo.Core.Addons;

namespace Ysfo.Tests.Core.Addons
{
    class MockAddon : Addon
    {
        public override void Load(string ysPath)
        {
            throw new NotImplementedException();
        }
    }
}
