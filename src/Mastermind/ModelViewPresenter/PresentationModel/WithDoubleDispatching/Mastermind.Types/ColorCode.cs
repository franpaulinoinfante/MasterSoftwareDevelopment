using System.Diagnostics;
using System.Text;

namespace Mastermind.Types;

public enum ColorCode
{
    Red,
    Green,
    Blue,
    Yellow,
    Magenta,
    Cyan,
    Null
}

public static class ColorCodeExtension
{
    public static bool IsNull(this ColorCode colorCode)
    {
        return colorCode == ColorCode.Null;
    }

    public static string GetInitials(this List<ColorCode> colorCodes)
    {
        Debug.Assert(colorCodes != null);

        StringBuilder sb = new StringBuilder();
        foreach (ColorCode colorCode in colorCodes)
        {
            sb.Append(GetInitial(colorCode));
        }
        return sb.ToString();
    }

    public static char GetInitial(this ColorCode colorCode)
    {
        return colorCode.ToString().ToLower()[index: 0];
    }
}
