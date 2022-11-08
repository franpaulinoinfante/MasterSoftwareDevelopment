internal class Error
{
    private readonly ErrorType _errorType;

    private readonly string[] ERRORS = new string[]
    {
        "The square is not empty",
        "There is not a token of yours",
        "The origin and target squares are the same",
        "The coordinates are wrong"
    };

    public Error(ErrorType errorType)
    {
        _errorType = errorType;
    }

    internal void WriteLine()
    {
        if (_errorType != ErrorType.NULL)
        {
            ConsoleIO.GetInstance().WriteLine(ERRORS[(int)_errorType]);
        }
    }
}
