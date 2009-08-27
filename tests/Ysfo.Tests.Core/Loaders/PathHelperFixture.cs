using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Ysfo.Core.Loaders;

namespace Ysfo.Tests.Core.Loaders
{
    [TestFixture]
    public class PathHelperFixture
    {
        readonly String _validYsPath = AppDomain.CurrentDomain.BaseDirectory;
        const String _validLstPath = "aircraft.lst";

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFullPathThrowsExceptionIfYsPathIsNull()
        {
            PathHelper.GetFullPath(null, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetFullPathThrowsExceptionIfRelPathIsNull()
        {
            PathHelper.GetFullPath(_validYsPath, null);
        }

        [Test]
        [ExpectedException(typeof(DirectoryNotFoundException))]
        public void GetFullPathThrowsExceptionIfYsPathIsInvalid()
        {
            String invalidYsPath = System.IO.Path.Combine(_validYsPath, "invaliddir");

            PathHelper.GetFullPath(invalidYsPath, _validLstPath);
        }

        [Test]
        public void GetFullPathDoesNotThrowExceptionIfYsPathAndRelPathAreValid()
        {
            PathHelper.GetFullPath(_validYsPath, _validLstPath);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConvertLstEntryToNativeThrowsExceptionIfLstEntryIsNull()
        {
            PathHelper.ConvertLstEntryToNative(null, '/');
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertLstEntryToNativeThrowsExceptionIfDirectorySeparatorCharIsInvalid()
        {
            PathHelper.ConvertLstEntryToNative("aircraft/aircraft.lst", 'a');
        }

        [Test]
        public void ConvertLstEntryIsCorrectForForwardSlashDirectorySeperatorChar()
        {
            String result = PathHelper.ConvertLstEntryToNative("aircraft\\aircraft.lst", '/');

            Assert.AreEqual("aircraft/aircraft.lst", result);
        }

        [Test]
        public void ConvertLstEntryIsCorrectForBackSlashDirectorySeperatorChar()
        {
            String result = PathHelper.ConvertLstEntryToNative("aircraft/aircraft.lst", '\\');

            Assert.AreEqual("aircraft\\aircraft.lst", result);
        }
    }
}
