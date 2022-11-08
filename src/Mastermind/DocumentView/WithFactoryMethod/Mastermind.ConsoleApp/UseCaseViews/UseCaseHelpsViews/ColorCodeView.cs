using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCaseViews.UseCaseHelpsViews;

internal class ColorCodeView
{
    private static readonly char[] ColorCodes = { 'r', 'g', 'y', 'b', 'm', 'c' };

    internal char GetInitital(ColorCode colorCode)
    {
        return ColorCodes[(int)colorCode];
    }

    internal string GetInititals()
    {
        string initials = string.Empty;
        foreach (char colorCode in ColorCodes)
        {
            initials += $"{colorCode}";
        }
        return initials;
    }

    internal void Write(ColorCode colorCode)
    {
        if (!colorCode.IsNull())
        {
            ConsoleIO.GetInstance().Write(ColorCodes[(int)colorCode]);
        }
    }
}