using System;
using System.Runtime.Serialization;

namespace eaw.hardpointduplicator.core.exception
{
    class MissingHardpointBaseNameException : Exception
    {
        public MissingHardpointBaseNameException()
        {
        }

        public MissingHardpointBaseNameException(string message) : base(message)
        {
        }

        public MissingHardpointBaseNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingHardpointBaseNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
