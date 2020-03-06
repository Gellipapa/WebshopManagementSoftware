using System;
using System.Runtime.Serialization;

namespace WebshopManagmentSoftware.myExceptions
{
    [Serializable]
    internal class ModelOrderNotValidProductQuantityException : Exception
    {
        public ModelOrderNotValidProductQuantityException()
        {
        }

        public ModelOrderNotValidProductQuantityException(string message) : base(message)
        {
        }

        public ModelOrderNotValidProductQuantityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelOrderNotValidProductQuantityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}