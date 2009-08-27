using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class SceneryFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void LoadMustLoadName()
        {
            var addon = new Ysfo.Core.SceneryAddon { LstEntry = "TEST_SCENERY test.srf" };
            addon.Load(_validYsPath);

            Assert.AreEqual("TEST_SCENERY", addon.Name);
        }
    }
}
