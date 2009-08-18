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
        public void LoadThrowsExceptionIfYsPathIsNull()
        {
            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfLstPathIsNull()
        {
            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(validYsPath, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfYsPathIsInvalid()
        {
            String invalidYsPath = System.IO.Path.Combine(validYsPath, "invaliddir");

            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(invalidYsPath, validLstPath);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfLstPathIsInvalid()
        {
            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(validYsPath, "invalid.lst");
        }

        [Test]
        public void LoadDoesNotThrowExceptionIfYsPathAndLstPathAreValid()
        {
            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(validYsPath, validLstPath);
        }

        [Test]
        public void LoadMustReturnOneAircraftForEachValidLineInLstFile()
        {
            var aircraft = Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(validYsPath, validLstPath);

            Assert.AreEqual(1, aircraft.Count);
        }

        [Test]
        public void LoadMustReturnValidAircraft()
        {
            var aircraft = Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(validYsPath, validLstPath);

            foreach (var a in aircraft)
            {
                Assert.AreEqual(typeof(Ysfo.Core.Aircraft), a.GetType());
            }
        }
    }
}
