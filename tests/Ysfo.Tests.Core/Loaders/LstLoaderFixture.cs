using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Ysfo.Core.Loaders;

namespace Ysfo.Tests.Core.Loaders
{
    [TestFixture]
    class LstLoaderFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;
        const String _validLstPath = "aircraft.lst";

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LoadThrowsExceptionIfYsPathIsNull()
        {
            LstLoader.Load<Ysfo.Core.AircraftAddon>(null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LoadThrowsExceptionIfLstPathIsNull()
        {
            LstLoader.Load<Ysfo.Core.AircraftAddon>(_validYsPath, null);
        }

        [Test]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void LoadThrowsExceptionIfYsPathIsInvalid()
        {
            String invalidYsPath = System.IO.Path.Combine(_validYsPath, "invaliddir");

            LstLoader.Load<Ysfo.Core.AircraftAddon>(invalidYsPath, _validLstPath);
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

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SaveThrowsExceptionIfYsPathIsNull()
        {
            LstLoader.Save<Ysfo.Core.AircraftAddon>(null, null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SaveThrowsExceptionIfLstPathIsNull()
        {
            LstLoader.Save<Ysfo.Core.AircraftAddon>(_validYsPath, null, null);
        }

        [Test]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void SaveThrowsExceptionIfYsPathIsInvalid()
        {
            String invalidYsPath = Path.Combine(_validYsPath, "invaliddir");

            LstLoader.Save<Ysfo.Core.AircraftAddon>(invalidYsPath, "test.lst", null);
        }

        [Test]
        public void SaveWritesFile()
        {
            // get output file path and ensure it doesn't exist
            String outputFile = Path.Combine(_validYsPath, "test.lst");
            Assert.IsFalse(File.Exists(outputFile), "test.lst file already exists!");

            // save
            LstLoader.Save(_validYsPath, "test.lst", new List<Ysfo.Core.AircraftAddon>());

            // make sure file created
            Assert.IsTrue(File.Exists(outputFile));

            // cleanup
            File.Delete(outputFile);
        }
    }
}