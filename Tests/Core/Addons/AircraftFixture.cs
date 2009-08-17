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
        [Test]
        public void ItMustSetNameInConstructor()
        {
            var aircraft = new Ysfo.Core.Addons.Aircraft("Test");

            Assert.AreEqual("Test", aircraft.Name);
        }
    }
}
