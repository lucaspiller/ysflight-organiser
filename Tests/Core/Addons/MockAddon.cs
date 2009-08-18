using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Tests.Core.Addons
{
    class MockAddon : Ysfo.Core.Addons.Addon
    {
        public override void Load(string ysPath)
        {
            throw new NotImplementedException();
        }
    }
}
