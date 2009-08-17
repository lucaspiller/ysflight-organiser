using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ysfo.Tests.Core.Loader
{
    [TestFixture]
    class DatLoaderFixture
    {
        [Test]
        public void Extractor_ItShouldReturnDatFileFromLstEntry()
        {
            String lstEntry = "aircraft/aircraft.dat aircraft/aircraft.dnm";

            String result = Ysfo.Core.Loader.DatLoader.GetDatFileFromLstEntry(lstEntry);

            Assert.AreEqual("aircraft/aircraft.dat", result);
        }

        [Test, ExpectedException(typeof(ArgumentException))]
        public void Extractor_ItShouldThrowAnExceptionWhenADatFileCannotBeFound()
        {
            String lstEntry = "aircraft/aircraft.dnm";

            Ysfo.Core.Loader.DatLoader.GetDatFileFromLstEntry(lstEntry);
        }
    }
}
