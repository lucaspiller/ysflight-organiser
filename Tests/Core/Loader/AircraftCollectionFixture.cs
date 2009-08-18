using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Loader
{
    [TestFixture]
    class AircraftCollectionFixture
    {
        String validYsPath;
        String validLstPath;

        [SetUp]
        public void Setup()
        {
            validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            validLstPath = "test.lst";
        }

        [Test]
        public void ItMustAcceptYsPathInConstructor()
        {
            var aircraft = new Ysfo.Core.AircraftCollection(validYsPath);
        }

        [Test]
        public void ItMustAcceptLstPathInConstructor()
        {
            var aircraft = new Ysfo.Core.AircraftCollection(validYsPath, "test.lst");
        }

        [Test]
        public void ConstructorMustAssignYsPath()
        {
            var aircraft = new Ysfo.Core.AircraftCollection(validYsPath);

            Assert.AreEqual(validYsPath, aircraft.YsPath);

            aircraft = new Ysfo.Core.AircraftCollection(validYsPath, "test.lst");

            Assert.AreEqual(validYsPath, aircraft.YsPath);
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var aircraft = new Ysfo.Core.AircraftCollection(validYsPath);

            Assert.AreEqual("aircraft/aircraft.lst", aircraft.LstPath);

            aircraft = new Ysfo.Core.AircraftCollection(validYsPath, "test.lst");

            Assert.AreEqual("test.lst", aircraft.LstPath);
        }

        [Test]
        public void ConstructorMustAssignDefaultLstPathWhenPassedNull()
        {
            var aircraft = new Ysfo.Core.AircraftCollection(validYsPath, null);

            Assert.AreEqual("aircraft/aircraft.lst", aircraft.LstPath);
        }

        [Test]
        public void LoadMustLoadAircraft()
        {
            var aircraft = new Ysfo.Core.AircraftCollection(validYsPath, validLstPath);

            Assert.AreEqual(0, aircraft.Count);

            aircraft.Load();

            Assert.AreEqual(1, aircraft.Count);
        }
    }
}
