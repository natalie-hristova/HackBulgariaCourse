using System;
using System.Runtime.Serialization;

namespace ShopInventory
{
    [Serializable]
    internal class NotAvailableInInventoryException : Exception
    {
        public NotAvailableInInventoryException()
        {
        }

        public NotAvailableInInventoryException(string message) : base(message)
        {
        }

        public NotAvailableInInventoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotAvailableInInventoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}