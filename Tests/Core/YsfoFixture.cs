using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core
{
    [TestFixture]
    public class YsfoFixture
    {
        readonly String _ysPath = AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void ItMustEnableThePathToBeSet()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;
            }
        }

        [Test]
        public void ItMustReturnAnAircraftCollectionOfValidAircraft()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                var aircraft = ysfo.GetAircraftCollection("aircraft.lst");

                Assert.AreEqual(1, aircraft.Count);
                Assert.AreEqual("TEST_AIRCRAFT", aircraft[0].Name);
            }
        }

        [Test]
        public void ItMustReturnAnGroundCollectionOfValidGround()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                var ground = ysfo.GetGroundCollection("ground.lst");

                Assert.AreEqual(1, ground.Count);
                Assert.AreEqual("TEST_GROUND", ground[0].Name);
            }
        }

        [Test]
        public void ItMustReturnAnSceneryCollectionOfValidScenery()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                var scenery = ysfo.GetSceneryCollection("scenery.lst");

                Assert.AreEqual(1, scenery.Count);
                Assert.AreEqual("TEST_SCENERY", scenery[0].Name);
            }
        }

        [Test]
        public void ItMustReturnAnAircraftCollectionWhenLstFileDoesntExist()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                ysfo.GetAircraftCollection();
            }
        }

        [Test]
        public void ItMustReturnAnGroundCollectionWhenLstFileDoesntExist()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                ysfo.GetGroundCollection();
            }
        }

        [Test]
        public void ItMustReturnAnSceneryCollectionWhenLstFileDoesntExist()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                ysfo.GetSceneryCollection();
            }
        }
    }
}
