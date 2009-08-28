using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ysfo.Core.Addons
{
    public class InvalidLstEntryException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the InvalidLstEntryException class,
        /// with the given error message and inner exception.
        /// </summary>
        /// <param name="message">The error message.</param>
        /// <param name="innerException">The inner exception.</param>
        public InvalidLstEntryException(String message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
