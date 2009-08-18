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
        public void ItMustReturnAnAircraftCollection()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                ysfo.GetAircraftCollection("test.lst");
            }
        }

        [Test]
        public void ItMustReturnAnAircraftCollectionOfAircraftWithAName()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = _ysPath;

                var aircraft = ysfo.GetAircraftCollection("test.lst");

                foreach (var a in aircraft)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }
    }
}
