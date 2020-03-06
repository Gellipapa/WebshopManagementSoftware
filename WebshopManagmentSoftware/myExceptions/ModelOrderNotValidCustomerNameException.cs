using System;
using System.Runtime.Serialization;

namespace WebshopManagmentSoftware.myExceptions
{
    [Serializable]
    internal class ModelOrderNotValidCustomerNameException : Exception
    {
        public ModelOrderNotValidCustomerNameException()
        {
        }

        public ModelOrderNotValidCustomerNameException(string message) : base(message)
        {
        }

        public ModelOrderNotValidCustomerNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ModelOrderNotValidCustomerNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}