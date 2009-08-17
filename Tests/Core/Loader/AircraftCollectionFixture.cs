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

            Assert.AreEqual(YsfoFixture.ysPath, aircraft.Debug_GetYsPath());

            aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath, "aircraft/aircraft.lst");

            Assert.AreEqual(YsfoFixture.ysPath, aircraft.Debug_GetYsPath());
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath);

            Assert.AreEqual(Ysfo.Core.Loader.AircraftCollection.DefaultLstPath, aircraft.LstPath);

            aircraft = new Ysfo.Core.Loader.AircraftCollection(YsfoFixture.ysPath, "aircraft/aircraft.lst");

            Assert.AreEqual("aircraft/aircraft.lst", aircraft.LstPath);
        }
    }
}
