internal class Token
{
    private TokenType _tokenType;

    public Token(TokenType tokenType)
    {
        _tokenType = tokenType;
    }

    private string[] TOKENS = new string[]
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
