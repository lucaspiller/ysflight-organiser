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
    }
}
