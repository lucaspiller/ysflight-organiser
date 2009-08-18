using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class SceneryFixture
    {
        String _validYsPath;

        [SetUp]
        public void Setup()
        {
            _validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        [Test]
        public void LoadMustLoadName()
        {
            var addon = new Ysfo.Core.SceneryAddon { LstEntry = "TEST_SCENERY test.srf" };
            addon.Load(_validYsPath);

            Assert.AreEqual("TEST_SCENERY", addon.Name);
        }
    }
}
