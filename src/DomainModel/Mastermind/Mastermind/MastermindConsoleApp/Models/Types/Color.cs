namespace MastermindConsoleApp.Models.Types;

internal enum Color
{
    Red,
    Green,
    Yellow,
    Blue,
    Magenta,
    Cyan,
    Null
}

internal static class ExtensionColorType
{
    private static readonly string[] ColorTypes =
    {
        "r",
        "g",
        "b",
        "y",
        "c",
        "m",
        ""
    };


    internal static string GetColorType(this Color colorType)
    {

        return ColorTypes[(int)colorType];
    }
}
