using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCaseViews.ViewModels;

internal class ProposedCombinationView
{
    internal IEnumerable<ColorCode> Read(PlayController playController)
    {
        List<ColorCode> colorCodes;
        ErrorCode errorCode;
        do
        {
            string characters = ConsoleIO.GetInstance().ReadString(MessageCode.ProposedCombination.GetMessage()).ToLower();
            colorCodes = GetColorCodes(characters);
            errorCode = playController.GetErrorCodeToProposedCombination(colorCodes);
            new ErrorView().WriteLine(errorCode);
        } while (!errorCode.IsNull());
        return colorCodes;

    }

    private List<ColorCode> GetColorCodes(string characters)
    {
        List<ColorCode> colorCodes = new List<ColorCode>();
        foreach (char c in characters)
        {
            colorCodes.Add(GetColorCode(c));
        }
        return colorCodes;
    }

    private ColorCode GetColorCode(char character)
    {
        ColorCode[] colorCodes = Enum.GetValues<ColorCode>();
        foreach (ColorCode colorCode in colorCodes)
        {
            if (colorCode.GetInitial() == character)
            {
                return colorCode;
            }
        }
        return ColorCode.Null;
    }

    internal void Write(IEnumerable<ColorCode> colorCodes)
    {
        foreach (ColorCode colorCode in colorCodes)
        {
            ConsoleIO.GetInstance().Write(colorCode.GetInitial());
        }
    }
}