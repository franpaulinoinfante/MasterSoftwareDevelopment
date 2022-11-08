using Mastermind.Types;
using System.Text;

namespace Mastermind.GameViews;

public abstract class ColorCodeView
{
    public string GetInitials()
    {
        List<ColorCode> colorCodes = Enum.GetValues<ColorCode>().ToList();
        StringBuilder stringBuilder = new StringBuilder();
        foreach (ColorCode colorCode in colorCodes)
        {
            stringBuilder.Append(GetInitial(colorCode).ToString());
        }
        return stringBuilder.ToString();
    }

    public char GetInitial(ColorCode colorCode)
    {
        return colorCode.ToString().ToLower()[0];
    }
}
