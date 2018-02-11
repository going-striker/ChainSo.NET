using System;

namespace ChainSo.NET.Model.Error
{
    public class ExceptionWithMessage<E> : Exception
    {
        public E ErrorMessage { get; }

        public ExceptionWithMessage(E errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
