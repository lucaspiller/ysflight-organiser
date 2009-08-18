using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Loader
{
    [TestFixture]
    class DatLoaderFixture
    {
        String validYsPath;

        [SetUp]
        public void Setup()
        {
            validYsPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        [Test]
        public void ItShouldLoadTheAddonName()
        {
            String identify = null;

            Dictionary<Regex, Ysfo.Core.Internal.DatLoader.StringSetDelegate> regexes = new Dictionary<Regex, Ysfo.Core.Internal.DatLoader.StringSetDelegate>() {
                { new Regex("IDENTIFY \"(.*)\""), delegate(String value) { identify = value; } }
            };

            Ysfo.Core.Internal.DatLoader.Load(validYsPath, "test.dat", regexes);

            Assert.AreEqual("TEST_ADDON", identify);
        }

        [Test]
        public void ItShouldLoadOtherAddonParameters()
        {
            String identify = null;
            String test = null;

            Dictionary<Regex, Ysfo.Core.Internal.DatLoader.StringSetDelegate> regexes = new Dictionary<Regex, Ysfo.Core.Internal.DatLoader.StringSetDelegate>() {
                { new Regex("IDENTIFY \"(.*)\""), delegate(String value) { identify = value; } },
                { new Regex("TEST (.*)"), delegate(String value) { test = value; } }
            };

            Ysfo.Core.Internal.DatLoader.Load(validYsPath, "test.dat", regexes);

            Assert.AreEqual("TEST_ADDON", identify);
            Assert.AreEqual("TRUE", test);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheLstEntryIsNull()
        {
            Ysfo.Core.Internal.DatLoader.Load(validYsPath, null, null);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheLstEntryIsInvalid()
        {
            Ysfo.Core.Internal.DatLoader.Load(validYsPath, "invalid.lst", null);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheBaseDirIsNull()
        {
            Ysfo.Core.Internal.DatLoader.Load(null, "test.dat", null);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void ItShouldThrowAnExceptionIfTheBaseDirIsInvalid()
        {
            String invalidYsPath = System.IO.Path.Combine(validYsPath, "invaliddir");

            Ysfo.Core.Internal.DatLoader.Load(invalidYsPath, "test.dat", null);
        }

        [Test]
        public void Extractor_ItShouldReturnDatFileFromLstEntry()
        {
            String lstEntry = "aircraft/aircraft.dat aircraft/aircraft.dnm";

            String result = Ysfo.Core.Internal.DatLoader.GetDatFileFromLstEntry(lstEntry);

            Assert.AreEqual("aircraft/aircraft.dat", result);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void Extractor_ItShouldThrowAnExceptionWhenADatFileCannotBeFound()
        {
            String lstEntry = "aircraft/aircraft.dnm";

            Ysfo.Core.Internal.DatLoader.GetDatFileFromLstEntry(lstEntry);
        }
    }
}
