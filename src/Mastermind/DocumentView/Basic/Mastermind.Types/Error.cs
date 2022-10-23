namespace Mastermind.Types;

public enum Error
{
    Duplicated,
    WrongCharacters,
    WrongLength,
    Null
}

public static class ErrorExtension
{
    public static bool IsNull(this Error error)
    {
        return error == Error.Null;
    }
}
