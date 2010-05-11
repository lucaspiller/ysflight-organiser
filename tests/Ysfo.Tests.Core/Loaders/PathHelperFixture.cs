using System;
using System.IO;
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
            String invalidYsPath = Path.Combine(_validYsPath, "invaliddir");

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

        [Test]
        public void IsPathValidReturnsFalseIfYsPathIsNull()
        {
            Boolean result = PathHelper.IsPathValid(null);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPathValidReturnsFalseIfYsFlightExecutableDoesntExist()
        {
            Boolean result = PathHelper.IsPathValid(_validYsPath);

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPathValidReturnsTrueIfValidOnWindowsWithFsMainDX()
        {
            String ysExecutable = Path.Combine(_validYsPath, PathHelper.WindowsDXExecutable);

            // create file
            File.Create(ysExecutable).Close();
            Assert.IsTrue(File.Exists(ysExecutable), "Temporary executable not created!");

            Boolean result = PathHelper.IsPathValid(_validYsPath);

            try
            {
                Assert.IsTrue(result);
            }
            finally
            {
                // cleanup
                File.Delete(ysExecutable);
                Assert.IsFalse(File.Exists(ysExecutable), "Temporary executable not removed!");
            }
        }

        [Test]
        public void IsPathValidReturnsTrueIfValidOnWindowsWithFsMainO()
        {
            String ysExecutable = Path.Combine(_validYsPath, PathHelper.WindowsOExecutable);

            // create file
            File.Create(ysExecutable).Close();
            Assert.IsTrue(File.Exists(ysExecutable), "Temporary executable not created!");

            Boolean result = PathHelper.IsPathValid(_validYsPath);

            try
            {
                Assert.IsTrue(result);
            }
            finally
            {
                // cleanup
                File.Delete(ysExecutable);
                Assert.IsFalse(File.Exists(ysExecutable), "Temporary executable not removed!");
            }
        }

        [Test]
        public void IsPathValidReturnsTrueIfValidOnLinux()
        {
            String ysExecutable = Path.Combine(_validYsPath, PathHelper.LinuxExecutable);

            // create file
            File.Create(ysExecutable).Close();
            Assert.IsTrue(File.Exists(ysExecutable), "Temporary executable not created!");

            Boolean result = PathHelper.IsPathValid(_validYsPath);

            try
            {
                Assert.IsTrue(result);
            }
            finally
            {
                // cleanup
                File.Delete(ysExecutable);
                Assert.IsFalse(File.Exists(ysExecutable), "Temporary executable not removed!");
            }
        }
    }
}
