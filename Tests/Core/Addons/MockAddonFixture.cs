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
        public void ToStringMustReturnPrettyName()
        {
            var addon = new MockAddon();

            addon.SetName("TEST_ADDON");

            Assert.AreEqual("TEST_ADDON", addon.Name);
            Assert.AreEqual(addon.GetPrettyName(), addon.ToString());
        }

        [Test]
        public void PrettyNameMustNotReturnNullIfNameIsNull()
        {
            var addon = new MockAddon();

            Assert.IsNull(addon.Name);
            Assert.IsNotNull(addon.GetPrettyName());
        }

        [Test]
        public void PrettyNameMustReturnTitleCaseName()
        {
            var addon = new MockAddon();

            addon.SetName("TEST_ADDON");

            Assert.AreEqual("TEST_ADDON", addon.Name);
            Assert.AreEqual("Test Addon", addon.GetPrettyName());
        }

    }
}
