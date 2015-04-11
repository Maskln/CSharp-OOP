namespace HealthBuddy.Exceptions
{
    using System;

    class UnHealthyException : ApplicationException
    {
        private const string unhealthyExMessage = @"Do not eat this! It is NOT good for you! 
Regards, your Healty Buddy  :* ";
        public UnHealthyException(string message = unhealthyExMessage)
            : base(message)
        {
        }
    }
}
