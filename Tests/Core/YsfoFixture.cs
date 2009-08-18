using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core
{
    [TestFixture]
    public class YsfoFixture
    {
        String _ysPath;

        [SetUp]
        public void Setup()
        {
            _ysPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

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

                foreach (var a in aircraft)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }

        [Test]
        public void ItMustReturnAnGroundCollectionOfValidGround()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                var ground = ysfo.GetGroundCollection("ground.lst");

                foreach (var a in ground)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }

        [Test]
        public void ItMustReturnAnSceneryCollectionOfValidScenery()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                var scenery = ysfo.GetSceneryCollection("scenery.lst");

                foreach (var a in scenery)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }
    }
}
