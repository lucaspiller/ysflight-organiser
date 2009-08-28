using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class AircraftFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void LoadMustLoadName()
        {
            var addon = new Ysfo.Core.AircraftAddon {LstEntry = "aircraft.dat"};
            addon.Load(_validYsPath);

            Assert.AreEqual("TEST_AIRCRAFT", addon.Name);
        }

        [Test]
        public void LoadMustLoadCategory()
        {
            var addon = new Ysfo.Core.AircraftAddon { LstEntry = "aircraft.dat" };
            addon.Load(_validYsPath);

            Assert.AreEqual("TEST_CATEGORY", addon.Category);
        }

        [Test]
        [ExpectedException(typeof(Ysfo.Core.Addons.InvalidLstEntryException))]
        public void LoadMustThrowExceptionWhenLstEntryIsInvalid()
        {
            var addon = new Ysfo.Core.AircraftAddon { LstEntry = "invalid" };
            addon.Load(_validYsPath);
        }

        [Test]
        public void CategoryPrettyMustReturnCategoryInTitleCase()
        {
            var addon = new Ysfo.Core.AircraftAddon { LstEntry = "aircraft.dat" };
            addon.Load(_validYsPath);

            Assert.AreEqual("Test Category", addon.CategoryPretty);
        }
    }
}
