namespace Shape.Calculation.Interfaces
{
    public class IncorrectShapeSizeException : Exception
    {
        public IncorrectShapeSizeException()
        {
        }

        public IncorrectShapeSizeException(string message) : base(message)
        {
        }

        public IncorrectShapeSizeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
