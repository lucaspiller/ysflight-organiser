using System;
using Ysfo.Core.Addons;

namespace Ysfo.Tests.Core.Addons
{
    public class MockAddon : Addon
    {
        public override void Load(String ysPath)
        {
            throw new NotImplementedException();
        }

        public void SetName(String name)
        {
            Name = name;
        }

        public String GetPrettyName()
        {
            return PrettyName();
        }
    }
}
