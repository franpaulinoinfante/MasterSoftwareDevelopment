using TicTacToe.Types;

internal class ErrorView
{
    private static readonly string[] MESSAGES = {
            "The square is not empty",
            "There is not a token of yours",
            "The origin and target squares are the same",
            "The coordinates are wrong"
    };

    internal void WriteLine(ErrorType errorCode)
    {
        ConsoleIO.GetInstance().WriteLine(MESSAGES[(int)errorCode]);
    }
}