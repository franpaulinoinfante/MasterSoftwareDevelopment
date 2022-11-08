using TicTacToe.Models.Types;

namespace TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;

internal class TokenView
{
    private readonly Token _token;

    private static readonly string[] TOKENS =
    {
        "X",
        "O",
        " "
    };

    public TokenView(Token token)
    {
        _token = token;
    }

    public override string ToString()
    {
        return TOKENS[(int)_token];
    }
}