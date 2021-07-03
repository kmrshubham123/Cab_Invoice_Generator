using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Class for custom Exception Handelling
    /// </summary>
    class CabInvoiceException : Exception
    {
        /// <summary>
        /// Enum For Exception Type
        /// </summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }

        ExceptionType type;

        /// <summary>
        /// Parameter constructor for setting Exception type and throwing Exception
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></The message that describes the error>
        public CabInvoiceException(ExceptionType type, string message) : base(message) 
        //Base:-Initializes a new instance of system.Exception class with a specified error message
        {
            this.type = type;
        }
    }
}
