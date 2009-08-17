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
    }
}
