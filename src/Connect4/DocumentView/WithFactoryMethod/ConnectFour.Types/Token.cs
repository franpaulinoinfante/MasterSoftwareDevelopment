namespace ConnectFour.Types;

public enum Token
{
    X,
    O,
    Null
}

public static class TokenExtension
{
    public static bool IsNull(this Token token)
    {
        return token == Token.Null;
    }

    public static string GetToString(this Token token)
    {
        if (!token.IsNull())
        {
            return token.ToString();
        }

        return " ";
    }
}
