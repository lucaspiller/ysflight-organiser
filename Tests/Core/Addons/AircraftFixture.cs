using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class AircraftFixture
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
            var addon = new Ysfo.Core.AircraftAddon {LstEntry = "aircraft.dat"};
            addon.Load(_validYsPath);

            Assert.AreEqual("TEST_AIRCRAFT", addon.Name);
        }
    }
}
