using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Ysfo.Core.Loaders
{
    public static class PathHelper
    {
        /// <summary>
        /// Combines a relative path with the path to the YsFlight base
        /// directory, checking the YsFlight base directory is valid.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <param name="relPath">The relative path to the file, from <paramref name="ysPath"/>.</param>
        /// <returns>The full path to the file.</returns>
        /// <exception cref="DirectoryNotFoundException">Directory <paramref name="ysPath"/> does not exist.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="ysPath"/> or <paramref name="relPath"/> is <code>null</code>.</exception>
        public static String GetFullPath(String ysPath, String relPath)
        {
            if (ysPath == null)
            {
                throw new ArgumentNullException("ysPath");
            }

            // Path.Combine already checks this, but faster to check before
            // File IO on directory check below
            if (relPath == null)
            {
                throw new ArgumentNullException("relPath");
            }

            if (!Directory.Exists(ysPath))
            {
                throw new DirectoryNotFoundException("Invalid ysPath; directory `" + ysPath + "' does not exist.");
            }

            return Path.Combine(ysPath, relPath);
        }

        /// <summary>
        /// Converts the directory seperators in a lst entry to their native format.
        /// </summary>
        /// <param name="lstEntry">The lst entry to be converted.</param></param>
        /// <returns>The lst entry, in native format.</returns>
        /// <remarks>The native directory seperator is retrieved from the
        /// <exception cref="ArgumentNullException"><paramref name="lstEntry"/> is null.</exception>
        /// <code>Path.DirectorySeparatorChar</code> field.</remarks>
        public static String ConvertLstEntryToNative(String lstEntry)
        {
            return ConvertLstEntryToNative(lstEntry, Path.DirectorySeparatorChar);
        }

        /// <summary>
        /// Converts the directory seperators in a lst entry to their native format.
        /// </summary>
        /// <param name="lstEntry">The lst entry to be converted.</param></param>
        /// <param name="directorySeparatorChar">The directory seperator character for this platform.</param>
        /// <returns>The lst entry, in native format.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="lstEntry"/> is null.</exception>
        /// <exception cref="ArgumentException">Directory seperator <paramref name="directorySeparatorChar"/> is unsupported.</exception>
        public static String ConvertLstEntryToNative(String lstEntry, char directorySeparatorChar)
        {
            if (lstEntry == null)
            {
                throw new ArgumentNullException("lstEntry");
            }

            switch(directorySeparatorChar)
            {
                // on Linux, convert \ to /
                case '/':
                    return lstEntry.Replace(@"\", "/");

                // on Windows, convert / to \
                case '\\':
                    return lstEntry.Replace("/", @"\");

                // some arcane platform
                default:
                    throw new ArgumentException("Unknown DirectorySeparatorChar `" + directorySeparatorChar + "'.");
            }
        }

        public const String WindowsExecutable = "fsmain.exe";
        public const String LinuxExecutable = "ysflight";

        /// <summary>
        /// Checks whether <paramref name="ysPath"/> is a valid YsFlight directory.
        /// </summary>
        /// <param name="ysPath">The path to the YsFlight base directory.</param>
        /// <returns><code>true</code> if <paramref name="ysPath"/> is valid.</returns>
        public static Boolean IsPathValid(String ysPath)
        {
            // check path is not null
            if (ysPath == null)
            {
                return false;
            }

            // check directory
            if (!Directory.Exists(ysPath))
            {
                return false;
            }

            // check ysflight exectutable
            if (!File.Exists(Path.Combine(ysPath, WindowsExecutable)) && !File.Exists(Path.Combine(ysPath, LinuxExecutable)))
            {
                return false;
            }

            // yay
            return true;
        }
    }
}
