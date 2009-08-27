using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class GroundFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void LoadMustLoadName()
        {
            var addon = new Ysfo.Core.GroundAddon { LstEntry = "ground.dat" };
            addon.Load(_validYsPath);

            Assert.AreEqual("TEST_GROUND", addon.Name);
        }
    }
}
