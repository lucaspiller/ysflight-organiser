using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;
using Ysfo.Core.Loaders;

namespace Ysfo.Tests.Core.Loaders
{
    [TestFixture]
    class DatLoaderFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void ItShouldLoadTheAddonName()
        {
            String identify = null;

            var regexes = new Dictionary<Regex, DatLoader.StringSetDelegate>
                              {
                                  { new Regex("IDENTIFY \"(.*)\""), delegate(String value) { identify = value; } }
                              };

            DatLoader.Load(_validYsPath, "aircraft.dat", regexes);

            Assert.AreEqual("TEST_AIRCRAFT", identify);
        }

        [Test]
        public void ItShouldLoadOtherAddonParameters()
        {
            String identify = null;
            String test = null;

            var regexes = new Dictionary<Regex, DatLoader.StringSetDelegate>
                              {
                                  { new Regex("IDENTIFY \"(.*)\""), delegate(String value) { identify = value; } },
                                  { new Regex("TEST (.*)"), delegate(String value) { test = value; } }
                              };

            DatLoader.Load(_validYsPath, "aircraft.dat", regexes);

            Assert.AreEqual("TEST_AIRCRAFT", identify);
            Assert.AreEqual("TRUE", test);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheLstEntryIsNull()
        {
            DatLoader.Load(_validYsPath, null, null);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheLstEntryIsInvalid()
        {
            DatLoader.Load(_validYsPath, "invalid.lst", null);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheBaseDirIsNull()
        {
            DatLoader.Load(null, "aircraft.dat", null);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheBaseDirIsInvalid()
        {
            String invalidYsPath = System.IO.Path.Combine(_validYsPath, "invaliddir");

            DatLoader.Load(invalidYsPath, "aircraft.dat", null);
        }

        [Test]
        public void Extractor_ItShouldReturnDatFileFromLstEntry()
        {
            const string lstEntry = "aircraft/aircraft.dat aircraft/aircraft.dnm";

            String result = DatLoader.GetDatFileFromLstEntry(lstEntry);

            Assert.AreEqual("aircraft/aircraft.dat", result);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void Extractor_ItShouldThrowAnExceptionWhenADatFileCannotBeFound()
        {
            const string lstEntry = "aircraft/aircraft.dnm";

            DatLoader.GetDatFileFromLstEntry(lstEntry);
        }
    }
}