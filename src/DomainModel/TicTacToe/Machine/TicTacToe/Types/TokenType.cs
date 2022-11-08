namespace TicTacToe.Types;

internal class TokenType
{
    private readonly string[] TOKENS =
    {
        "X",
        "O",
        " "
    };

    public string ToString(Token token)
    {
        return TOKENS[(int)token];
    }
}
