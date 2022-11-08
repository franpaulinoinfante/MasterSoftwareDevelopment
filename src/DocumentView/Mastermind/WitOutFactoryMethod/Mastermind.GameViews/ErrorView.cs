using Mastermind.Types;

namespace Mastermind.GameViews;

public abstract class ErrorView
{
    protected static string[] Errors =
    {
        "There are duplicated colors",
        $"Wrong colors, they must be: {GetAllInitials()}",
        "Wrong proposed combination length"
    };

    private static string GetAllInitials()
    {
        ColorCode[] colorCodes = Enum.GetValues<ColorCode>();
        string initials = string.Empty;
        for (int i = 0; i < colorCodes.Length - 1; i++)
        {
            initials += colorCodes[i].GetInitial();
        }
        return initials;
    }

    public abstract void WriteLine(ErrorCode errorCode);
}

