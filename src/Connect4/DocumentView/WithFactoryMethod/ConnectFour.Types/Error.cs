namespace ConnectFour.Types;

public enum Error
{
    TheColunmIsComplete,
    TheColunmIsOutOfRange,
    ThePlayersIsOutOfRange,
    Null
}

public static class ErrorExtension
{
    public static bool IsNull(this Error error)
    {
        return error == Error.Null;
    }
}
