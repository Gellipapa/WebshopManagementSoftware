using System;
using System.Runtime.Serialization;

namespace WebshopManagmentSoftware.myExceptions
{
    [Serializable]
    internal class ModelOrderNotValidProductPriceException : Exception
    {
        public ModelOrderNotValidProductPriceException()
        {
        }

        public ModelOrderNotValidProductPriceException(string message) : base(message)
        {
        }

        public ModelOrderNotValidProductPriceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelOrderNotValidProductPriceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}