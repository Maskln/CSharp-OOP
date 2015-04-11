namespace RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
                 where T : IComparable<T>
    {
        private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception ex)
            : base(string.Format("{0} Parameter must be in range {1} to {2}", message, start, end), ex)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {

        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null)
        {

        }

        public T Start
        {
            get
            {
                return this.start;
            }
            private set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            private set
            {
                this.end = value;
            }
        }
    }
}
