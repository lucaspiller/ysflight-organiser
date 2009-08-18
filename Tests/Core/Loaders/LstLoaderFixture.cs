using System;
using NUnit.Framework;
using Ysfo.Core.Loaders;

namespace Ysfo.Tests.Core.Loaders
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
            LstLoader.Load<Ysfo.Core.AircraftAddon>(null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfLstPathIsNull()
        {
            LstLoader.Load<Ysfo.Core.AircraftAddon>(_validYsPath, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfYsPathIsInvalid()
        {
            String invalidYsPath = System.IO.Path.Combine(_validYsPath, "invaliddir");

            LstLoader.Load<Ysfo.Core.AircraftAddon>(invalidYsPath, _validLstPath);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void LoadThrowsExceptionIfLstPathIsInvalid()
        {
            LstLoader.Load<Ysfo.Core.AircraftAddon>(_validYsPath, "invalid.lst");
        }

        [Test]
        public void LoadDoesNotThrowExceptionIfYsPathAndLstPathAreValid()
        {
            LstLoader.Load<Ysfo.Core.AircraftAddon>(_validYsPath, _validLstPath);
        }

        [Test]
        public void LoadMustReturnOneAircraftForEachValidLineInLstFile()
        {
            var aircraft = LstLoader.Load<Ysfo.Core.AircraftAddon>(_validYsPath, _validLstPath);

            Assert.AreEqual(1, aircraft.Count);
        }

        [Test]
        public void LoadMustReturnValidAircraft()
        {
            var aircraft = LstLoader.Load<Ysfo.Core.AircraftAddon>(_validYsPath, _validLstPath);

            foreach (var a in aircraft)
            {
                Assert.AreEqual(typeof(Ysfo.Core.AircraftAddon), a.GetType());
            }
        }
    }
}