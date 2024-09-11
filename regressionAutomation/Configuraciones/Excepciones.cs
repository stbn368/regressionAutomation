using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace regressionAutomation.Configuraciones
{
    public class MultipleElementsFoundException : Exception
    {
        public MultipleElementsFoundException()
        {
        }

        public MultipleElementsFoundException(string? message) : base(message)
        {
        }

        public MultipleElementsFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MultipleElementsFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
