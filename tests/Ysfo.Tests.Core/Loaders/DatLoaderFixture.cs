using System;
using System.IO;
using NUnit.Framework;
using Ysfo.Core.Loaders;

namespace Ysfo.Tests.Core.Loaders
{
    [TestFixture]
    class DatLoaderFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;
        const String _validLstEntry = "aircraft.dat aircraft.dnm";

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LoadThrowsExceptionIfYsPathIsNull()
        {
            var loader = new DatLoader(null, null);
            loader.AddRegex("IDENTIFY \"(.*)\"");
            loader.Load();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LoadThrowsExceptionIfLstPathIsNull()
        {
            var loader = new DatLoader(_validYsPath, null);
            loader.AddRegex("IDENTIFY \"(.*)\"");
            loader.Load();
        }

        [Test]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void LoadThrowsExceptionIfYsPathIsInvalid()
        {
            String invalidYsPath = Path.Combine(_validYsPath, "invaliddir");

            var loader = new DatLoader(invalidYsPath, _validLstEntry);
            loader.AddRegex("IDENTIFY \"(.*)\"");
            loader.Load();
        }

        [Test]
        public void LoadDoesNotThrowExceptionIfYsPathAndLstPathAreValid()
        {
            var loader = new DatLoader(_validYsPath, _validLstEntry);
            loader.AddRegex("IDENTIFY \"(.*)\"");
            loader.Load();
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LoadThrowsAnExceptionIfNoRegexIsSet()
        {
            new DatLoader(_validYsPath, _validLstEntry).Load();
        }

        [Test]
        public void ItShouldLoadTheAddonName()
        {
            var loader = new DatLoader(_validYsPath, _validLstEntry);
            var identifyRegex = loader.AddRegex("IDENTIFY \"(.*)\"");

            // load
            loader.Load();

            Assert.AreEqual("TEST_AIRCRAFT", loader.GetValue(identifyRegex));
        }

        [Test]
        public void ItShouldLoadOtherAddonParameters()
        {
            var loader = new DatLoader(_validYsPath, _validLstEntry);
            var identifyRegex = loader.AddRegex("IDENTIFY \"(.*)\"");
            var testRegex = loader.AddRegex("TEST (.*)");

            // load
            loader.Load();

            Assert.AreEqual("TEST_AIRCRAFT", loader.GetValue(identifyRegex));
            Assert.AreEqual("TRUE", loader.GetValue(testRegex));
        }

        [Test]
        public void Extractor_ItShouldReturnDatFileFromLstEntry()
        {
            String datPart = Path.Combine("aircraft", "aircraft.dat");
            String dnmPart = Path.Combine("aircraft", "aircraft.dnm");

            String result = DatLoader.GetDatFileFromLstEntry(datPart + " " + dnmPart);

            Assert.AreEqual(datPart, result);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void Extractor_ItShouldThrowAnExceptionWhenADatFileCannotBeFound()
        {
            const string lstEntry = "aircraft\\aircraft.dnm";

            DatLoader.GetDatFileFromLstEntry(lstEntry);
        }

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void Extractor_ItShouldThrowAnExceptionWhenLstEntryIsNull()
        {
            DatLoader.GetDatFileFromLstEntry(null);
        }
    }
}