using System.Text;

namespace Mastermind.Types;

public enum ColorCode
{
    Red,
    Green,
    Yellow,
    Blue,
    Magenta,
    Cyan,
    Null,
}

public static class ColorCodeExtension
{
    private static readonly int Initial = 0;

    public static bool IsNull(this ColorCode colorCode)
    {
        return colorCode == ColorCode.Null;
    }

    public static string Getinitials(this IEnumerable<ColorCode> colorCodes)
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (ColorCode colorCode in colorCodes)
        {
            stringBuilder.Append(GetInitial(colorCode).ToString());
        }
        return stringBuilder.ToString();
    }

    public static char GetInitial(this ColorCode colorCode)
    {
        return colorCode.ToString().ToLower()[Initial];
    }
}
