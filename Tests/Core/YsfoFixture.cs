using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ysfo.Tests.Core
{
    [TestFixture]
    public class YsfoFixture
    {
        String ysPath;

        [SetUp]
        public void Setup()
        {
            ysPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        [Test]
        public void ItMustEnableThePathToBeSet()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = ysPath;
            }
        }

        [Test]
        public void ItMustReturnAnAircraftCollection()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = ysPath;

                var aircraft = ysfo.GetAircraftCollection("test.lst");
            }
        }

        [Test]
        public void ItMustReturnAnAircraftCollectionWhichIsIteratable()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = ysPath;

                var aircraft = ysfo.GetAircraftCollection("test.lst");

                foreach (var a in aircraft)
                {
                }
            }
        }

        [Test]
        public void ItMustReturnAnAircraftCollectionOfAircraftWithAName()
        {
            using (var ysfo = new Ysfo.Core.Ysfo())
            {
                ysfo.Path = ysPath;

                var aircraft = ysfo.GetAircraftCollection("test.lst");

                foreach (var a in aircraft)
                {
                    Console.WriteLine(a.Name);
                }
            }
        }
    }
}
