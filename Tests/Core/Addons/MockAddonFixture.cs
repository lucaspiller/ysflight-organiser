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
        [ExpectedException(typeof(ArgumentException))]
        public void AddonCollectionMustNotUnderstandMockAddon()
        {
            var addon = new Ysfo.Core.Loader.AddonCollection<MockAddon>("test");
        }
    }
}
