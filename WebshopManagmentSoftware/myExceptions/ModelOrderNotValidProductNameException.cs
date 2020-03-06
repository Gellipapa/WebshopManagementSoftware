using System;
using System.Runtime.Serialization;

namespace WebshopManagmentSoftware.myExceptions
{
    [Serializable]
    internal class ModelOrderNotValidProductNameException : Exception
    {
        public ModelOrderNotValidProductNameException()
        {
        }

        public ModelOrderNotValidProductNameException(string message) : base(message)
        {
        }

        public ModelOrderNotValidProductNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelOrderNotValidProductNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}