using System;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Loader
{
    [TestFixture]
    class LstLoaderFixture
    {
        String _validYsPath;
        String _validLstPath;

        [SetUp]
        public void Setup()
        {
            _validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _validLstPath = "aircraft.lst";
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
            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(_validYsPath, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfYsPathIsInvalid()
        {
            String invalidYsPath = System.IO.Path.Combine(_validYsPath, "invaliddir");

            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(invalidYsPath, _validLstPath);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfLstPathIsInvalid()
        {
            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(_validYsPath, "invalid.lst");
        }

        [Test]
        public void LoadDoesNotThrowExceptionIfYsPathAndLstPathAreValid()
        {
            Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(_validYsPath, _validLstPath);
        }

        [Test]
        public void LoadMustReturnOneAircraftForEachValidLineInLstFile()
        {
            var aircraft = Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(_validYsPath, _validLstPath);

            Assert.AreEqual(1, aircraft.Count);
        }

        [Test]
        public void LoadMustReturnValidAircraft()
        {
            var aircraft = Ysfo.Core.Internal.LstLoader.Load<Ysfo.Core.Aircraft>(_validYsPath, _validLstPath);

            foreach (var a in aircraft)
            {
                Assert.AreEqual(typeof(Ysfo.Core.Aircraft), a.GetType());
            }
        }
    }
}
