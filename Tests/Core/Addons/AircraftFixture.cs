using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class AircraftFixture
    {
        String validYsPath;

        [SetUp]
        public void Setup()
        {
            validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        [Test]
        public void ItMustSetLstEntryInConstructor()
        {
            String testEntry = "TEST.DAT TEST.DNM TEST.SRF";

            var aircraft = new Ysfo.Core.Addons.Aircraft(testEntry);

            Assert.AreEqual(testEntry, aircraft.LstEntry);
        }

        [Test]
        public void LoadMustLoadName()
        {
            var aircraft = new Ysfo.Core.Addons.Aircraft("test.dat");

            aircraft.Load(validYsPath);

            Assert.AreEqual("TEST_ADDON", aircraft.Name);
        }
    }
}
