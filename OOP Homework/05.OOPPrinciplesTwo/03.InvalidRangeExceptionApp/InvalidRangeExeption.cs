namespace InvalidRangeExceptionApp
{
    using System;

    public class InvalidRangeException<T> : Exception
    {
        // constant error message
        private const string errorMessage = "Invalid range!";

        // properties
        public T Start { get; private set; }

        public T End { get; private set; }

        //  constructor
        public InvalidRangeException(T start, T end, Exception exception = null) : base(errorMessage, exception)
        {
            this.Start = start;
            this.End = end;
        }
    }
}