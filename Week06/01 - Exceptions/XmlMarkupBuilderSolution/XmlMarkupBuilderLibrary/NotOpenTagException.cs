using System;
using System.Runtime.Serialization;

namespace XmlMarkupBuilderLibrary
{
    [Serializable]
    internal class NotOpenTagException : Exception
    {
        public NotOpenTagException()
        {
        }

        public NotOpenTagException(string message) : base(message)
        {
        }

        public NotOpenTagException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotOpenTagException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}