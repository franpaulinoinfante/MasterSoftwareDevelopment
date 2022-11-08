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
    public static bool IsNull(this ColorCode color)
    {
        return color == ColorCode.Null;
    }
}