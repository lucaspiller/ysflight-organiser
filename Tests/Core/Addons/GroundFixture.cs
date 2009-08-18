using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class GroundFixture
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
            var addon = new Ysfo.Core.GroundAddon { LstEntry = "ground.dat" };
            addon.Load(_validYsPath);

            Assert.AreEqual("TEST_GROUND", addon.Name);
        }
    }
}
