namespace MastermindConsoleApp.Models.Types;

internal enum ColorType
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
    private static string[] ColorTypes =
    {
        "r",
        "g",
        "b",
        "y",
        "c",
        "m",
        ""
    };


    internal static string GetColorType(this ColorType colorType)
    {

        return ColorTypes[(int)colorType];
    }
}
