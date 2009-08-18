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
            var aircraft = new Ysfo.Core.Aircraft {LstEntry = "aircraft.dat"};
            aircraft.Load(_validYsPath);

            Assert.AreEqual("TEST_AIRCRAFT", aircraft.Name);
        }
    }
}
