namespace Mastermind.Types;

public enum ColorCode
{
    Red,
    Green,
    Yellow,
    Blue,
    Magenta,
    Cyan,
    Null
}

public static class ColorExtension
{
    private const int Initial = 0;

    public static bool IsNull(this ColorCode color)
    {
        return color == ColorCode.Null;
    }

    public static char GetInitial(this ColorCode color)
    {
        return color.ToString().ToLower()[Initial];
    }
}