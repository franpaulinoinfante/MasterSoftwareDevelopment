namespace Mastermind.Types;

public enum ErrorCode
{
    Duplicate,
    WrongCharacters,
    WrongLength,
    Null
}

public static class ErrorCodeExtension
{
    public static bool IsNull(this ErrorCode errorCode)
    {
        return errorCode == ErrorCode.Null;
    }
}
