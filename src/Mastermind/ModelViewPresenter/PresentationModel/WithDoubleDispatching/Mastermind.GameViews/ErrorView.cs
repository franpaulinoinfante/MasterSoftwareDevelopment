using Mastermind.Types;

namespace Mastermind.GameViews;

public abstract class ErrorView
{
    protected string[] Errors =
    {
        "There are duplicated colors",
        $"Wrong colors, they must be: {Enum.GetValues<ColorCode>().ToList().GetInitials()}",
        "Wrong proposed combination length"
    };

    public abstract void WriteLine(ErrorCode errorCode);
}
