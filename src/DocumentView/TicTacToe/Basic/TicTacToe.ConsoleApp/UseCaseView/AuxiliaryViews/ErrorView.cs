using TicTacToe.ConsoleApp.ConsolesIOs;
using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;

internal class ErrorView
{
    private readonly ErrorType _errorType;

    private static readonly string[] ERRORS =
    {
        "The square is not empty",
        "There is not a token of yours",
        "The origin and target squares are the same",
        "The coordinates are wrong"
    };

    public ErrorView(ErrorType errorType)
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