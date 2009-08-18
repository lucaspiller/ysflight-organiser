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
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfYsPathIsInvalid()
        {
            Ysfo.Core.Loader.LstLoader.Load<Ysfo.Core.Addons.Aircraft>(null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfLstPathIsInvalid()
        {
            Ysfo.Core.Loader.LstLoader.Load<Ysfo.Core.Addons.Aircraft>(validYsPath, null);
        }

        [Test]
        public void LoadDoesNotThrowExceptionIfYsPathAndLstPathAreValid()
        {
            Ysfo.Core.Loader.LstLoader.Load<Ysfo.Core.Addons.Aircraft>(validYsPath, validLstPath);
        }

        [Test]
        public void LoadMustReturnOneAircraftForEachValidLineInLstFile()
        {
            var aircraft = Ysfo.Core.Loader.LstLoader.Load<Ysfo.Core.Addons.Aircraft>(validYsPath, validLstPath);

            Assert.AreEqual(1, aircraft.Count);
        }

        [Test]
        public void LoadMustReturnValidAircraft()
        {
            var aircraft = Ysfo.Core.Loader.LstLoader.Load<Ysfo.Core.Addons.Aircraft>(validYsPath, validLstPath);

            foreach (var a in aircraft)
            {
                Assert.AreEqual(typeof(Ysfo.Core.Addons.Aircraft), a.GetType());
            }
        }
    }
}
