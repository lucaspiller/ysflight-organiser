using System;
using NUnit.Framework;
using Ysfo.Core.Collections;

namespace Ysfo.Tests.Core.Collections
{
    [TestFixture]
    class AircraftCollectionFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;
        const String _validLstPath = "aircraft.lst";

        [Test]
        public void ItMustAcceptYsPathInConstructor()
        {
            new AircraftCollection(_validYsPath);
        }

        [Test]
        public void ItMustAcceptLstPathInConstructor()
        {
            new AircraftCollection(_validYsPath, "aircraft.lst");
        }

        [Test]
        public void ConstructorMustAssignYsPath()
        {
            var aircraft = new AircraftCollection(_validYsPath);

            Assert.AreEqual(_validYsPath, aircraft.YsPath);

            aircraft = new AircraftCollection(_validYsPath, "aircraft.lst");

            Assert.AreEqual(_validYsPath, aircraft.YsPath);
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var aircraft = new AircraftCollection(_validYsPath);

            Assert.AreEqual("aircraft/aircraft.lst", aircraft.LstPath);

            aircraft = new AircraftCollection(_validYsPath, "aircraft.lst");

            Assert.AreEqual("aircraft.lst", aircraft.LstPath);
        }

        [Test]
        public void ConstructorMustAssignDefaultLstPathWhenPassedNull()
        {
            var aircraft = new AircraftCollection(_validYsPath, null);

            Assert.AreEqual("aircraft/aircraft.lst", aircraft.LstPath);
        }

        [Test]
        public void LoadMustLoadAircraft()
        {
            var aircraft = new AircraftCollection(_validYsPath, _validLstPath);

            Assert.AreEqual(0, aircraft.Count);

            aircraft.Load();

            Assert.AreEqual(1, aircraft.Count);
        }
    }
}