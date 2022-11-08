namespace Mastermind.Types;

public enum ErrorCode
{
    Duplicated,
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
