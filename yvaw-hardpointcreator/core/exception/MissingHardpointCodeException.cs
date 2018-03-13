using System;
using System.Runtime.Serialization;

namespace yvaw_hardpointcreator.core.exception
{
    class MissingHardpointCodeException : Exception
    {
        public MissingHardpointCodeException()
        {
        }

        public MissingHardpointCodeException(string message) : base(message)
        {
        }

        public MissingHardpointCodeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingHardpointCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
