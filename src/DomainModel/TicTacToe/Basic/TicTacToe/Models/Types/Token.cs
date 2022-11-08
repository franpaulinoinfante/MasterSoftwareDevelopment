internal class Token
{
    private readonly TokenType _tokenType;

    public Token(TokenType tokenType)
    {
        _tokenType = tokenType;
    }

    private readonly string[] TOKENS = new string[]
    {
        "X",
        "O",
        " "
    };

    public override string ToString()
    {
        return TOKENS[(int)_tokenType];
    }
}
