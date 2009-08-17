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
        String validYsPath;
        String validLstPath;

        [SetUp]
        public void Setup()
        {
            validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            validLstPath = "test.lst";
        }

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

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfYsPathIsInvalid()
        {
            var loader = new Ysfo.Core.Loader.LstLoader(null, null);

            loader.Load();
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfLstPathIsInvalid()
        {
            var loader = new Ysfo.Core.Loader.LstLoader(validYsPath, null);

            loader.Load();
        }

        [Test]
        public void LoadDoesNotThrowExceptionIfYsPathAndLstPathAreValid()
        {
            var loader = new Ysfo.Core.Loader.LstLoader(validYsPath, validLstPath);

            loader.Load();
        }

        [Test]
        public void LoadMustReturnOneAircraftForEachValidLineInLstFile()
        {
            var loader = new Ysfo.Core.Loader.LstLoader(validYsPath, validLstPath);

            var aircraft = loader.Load();

            Assert.AreEqual(1, aircraft.Count);
        }

        [Test]
        public void LoadMustReturnValidAircraft()
        {
            var loader = new Ysfo.Core.Loader.LstLoader(validYsPath, validLstPath);

            var aircraft = loader.Load();

            foreach (var a in aircraft)
            {
                Assert.AreEqual(typeof(Ysfo.Core.Addons.Aircraft), a.GetType());
            }
        }
    }
}
