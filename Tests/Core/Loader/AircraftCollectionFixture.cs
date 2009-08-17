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
        [Test]
        public void ItMustAcceptYsPathInConstructor()
        {
            var aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath);
        }

        [Test]
        public void ItMustAcceptLstPathInConstructor()
        {
            var aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath, "aircraft/aircraft.lst");
        }

        [Test]
        public void ConstructorMustAssignYsPath()
        {
            var aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath);

            Assert.AreEqual(YsfoFixture.ysPath, aircraft.YsPath);

            aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath, "aircraft/aircraft.lst");

            Assert.AreEqual(YsfoFixture.ysPath, aircraft.YsPath);
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath);

            Assert.AreEqual(Ysfo.Core.Loader.AircraftCollection.DefaultLstPath, aircraft.LstPath);

            aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath, "aircraft/aircraft.lst");

            Assert.AreEqual("aircraft/aircraft.lst", aircraft.LstPath);
        }

        [Test]
        public void ConstructorMustAssignDefaultLstPathWhenPassedNull()
        {
            var aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath, null);

            Assert.AreEqual(Ysfo.Core.Loader.AircraftCollection.DefaultLstPath, aircraft.LstPath);
        }
    }
}
