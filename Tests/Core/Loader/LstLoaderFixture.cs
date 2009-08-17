using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Loader
{
    [TestFixture]
    class LstLoaderFixture
    {
        [Test]
        public void ConstructorCanTakeNoArguments()
        {
            var loader = new Ysfo.Core.Loader.LstLoader();
        }

        [Test]
        public void ConstructorTakesYsPathAndLstPathAsArguments()
        {
            var loader = new Ysfo.Core.Loader.LstLoader("Test", "Test");
        }

        [Test]
        public void ConstructorMustAssignYsPath()
        {
            var loader = new Ysfo.Core.Loader.LstLoader("Test", null);

            Assert.AreEqual("Test", loader.YsPath);
        }

        [Test]
        public void ConstructorMustAssignLstPath()
        {
            var loader = new Ysfo.Core.Loader.LstLoader(null, "Test");

            Assert.AreEqual("Test", loader.LstPath);
        }
    }
}
