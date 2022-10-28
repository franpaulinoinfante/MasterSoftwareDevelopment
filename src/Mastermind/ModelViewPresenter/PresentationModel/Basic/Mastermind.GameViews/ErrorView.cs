using Mastermind.Types;
using System.Text;

namespace Mastermind.GameViews;

public abstract class ErrorView
{
    protected string[] Errors =
    {
        "There are duplicated colors",
        $"Wrong colors, they must be: {GetInitials()}",
        "Wrong proposed combination length"
    };

    private static string GetInitials()
    {
        StringBuilder stringBuilder = new StringBuilder();
        List<ColorCode> colors = Enum.GetValues<ColorCode>().ToList();
        foreach (ColorCode colorCode in colors)
        {
            stringBuilder.Append(colorCode.GetInitial());
        }
        return stringBuilder.ToString();
    }

    public abstract void WriteLine(ErrorCode errorCode);
}
