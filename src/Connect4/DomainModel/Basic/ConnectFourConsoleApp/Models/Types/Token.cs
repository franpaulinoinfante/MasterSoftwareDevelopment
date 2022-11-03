using ConnectFourConsoleApp.ConsoleIOs;

namespace ConnectFourConsoleApp;

internal enum Token
{
    X,
    O,
    Null
}

internal static class TokenExtension
{
    internal static bool IsNull(this Token token)
    {
        return token == Token.Null;
    }

    internal static void Write(this Token token)
    {
        string strg = token.ToString();
        if (token.IsNull())
        {
            strg = " ";
        }
        ConsoleIO.GetInstance().Write(strg);
    }
}