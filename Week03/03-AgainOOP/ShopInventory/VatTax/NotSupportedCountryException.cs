using System;
using System.Runtime.Serialization;

namespace VatTax
{
    [Serializable]
    internal class NotSupportedCountryException : Exception
    {
        public NotSupportedCountryException()
        {
        }

        public NotSupportedCountryException(string message) : base(message)
        {
        }

        public NotSupportedCountryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotSupportedCountryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}