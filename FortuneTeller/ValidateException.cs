using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    /// <summary>
    /// Validate Exception inherits Exception
    /// </summary>
    public class ValidateException : Exception
    {
        /// <summary>
        /// Constructor for ValidateException
        /// </summary>
        /// <param name="message"></param>
        public ValidateException(string message) :
            base(message)
        { }
    }
}
