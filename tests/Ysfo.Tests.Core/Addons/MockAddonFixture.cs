using System;
using NUnit.Framework;
using Ysfo.Core.Collections;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class MockAddonFixture
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AddonCollectionMustNotUnderstandMockAddon()
        {
            new AddonCollection<MockAddon>("test");
        }

        [Test]
        public void NamePrettyMustNotReturnNullIfNameIsNull()
        {
            var addon = new MockAddon();

            Assert.IsNull(addon.Name);
            Assert.IsNotNull(addon.NamePretty);
        }

        [Test]
        public void NamePrettyMustReturnNameInTitleCase()
        {
            var addon = new MockAddon();

            addon.SetName("TEST_ADDON");

            Assert.AreEqual("TEST_ADDON", addon.Name);
            Assert.AreEqual("Test Addon", addon.NamePretty);
        }
    }
}
