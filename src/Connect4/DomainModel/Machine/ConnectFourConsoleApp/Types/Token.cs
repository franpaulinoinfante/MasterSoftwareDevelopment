using ConnectFourConsoleApp.ConsoleIOs;

namespace ConnectFourConsoleApp.Types;
internal enum Token
{
    X,
    O,
    Null
}

internal static class TokenExtension
{
    internal static void Write(this Token token)
    {
        if (token.IsNull())
        {
            ConsoleIO.Instance.Write(" ");
        }
        else
        {
            ConsoleIO.Instance.Write(token.ToString());
        }
    }

    internal static bool IsNull(this Token token)
    {
        return token == Token.Null;
    }
}
