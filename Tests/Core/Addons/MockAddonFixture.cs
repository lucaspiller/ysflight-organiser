using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class MockAddonFixture
    {
        [Test]
        public void ItMustSetLstEntryInConstructor()
        {
            String testEntry = "TEST.DAT TEST.DNM TEST.SRF";

            var aircraft = new Ysfo.Core.Addons.Aircraft(testEntry);

            Assert.AreEqual(testEntry, aircraft.LstEntry);
        }
    }
}
