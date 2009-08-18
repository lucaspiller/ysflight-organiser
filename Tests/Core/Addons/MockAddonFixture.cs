using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Addons
{
    [TestFixture]
    class MockAddonFixture
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void AddonCollectionMustNotUnderstandMockAddon()
        {
            new Ysfo.Core.Internal.AddonCollection<MockAddon>("test");
        }
    }
}
