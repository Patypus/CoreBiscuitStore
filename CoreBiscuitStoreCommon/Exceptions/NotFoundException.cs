using System;

namespace CoreBiscuitStoreCommon.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
    }
}