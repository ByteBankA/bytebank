namespace bytebank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException(string? message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
