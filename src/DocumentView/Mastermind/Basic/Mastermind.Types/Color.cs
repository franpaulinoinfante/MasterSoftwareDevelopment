namespace Mastermind.Types;

public enum Color
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
    private static readonly int First = 0;

    public static bool IsNull(this Color color)
    {
        return color == Color.Null;
    }

    public static char GetInitial(this Color color)
    {
        return color.ToString().ToLower()[First];
    }
}