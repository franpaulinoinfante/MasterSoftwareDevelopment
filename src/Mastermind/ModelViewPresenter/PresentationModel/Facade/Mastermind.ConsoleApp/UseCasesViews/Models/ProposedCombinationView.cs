using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCasesViews.Models;

internal class ProposedCombinationView
{
    internal IEnumerable<ColorCode> Read(Logic logic)
    {
        List<ColorCode> colorCodes;
        ErrorCode error;
        do
        {
            string characters = ConsoleIO.GetInstance().ReadString(MessageCode.ProposedCombination.GetMessage()).ToLower();
            colorCodes = GetColorCodes(characters);
            error = logic.GetErrorCodeToProposedCombination(colorCodes);
            new ErrorView().WriteLine(error);
        } while (!error.IsNull());
        return colorCodes;
    }

    private List<ColorCode> GetColorCodes(string characters)
    {
        List<ColorCode> colorCodes = new List<ColorCode>();
        for (int i = 0; i < characters.Length; i++)
        {
            colorCodes.Add(GetColorCode(characters[i]));
        }
        return colorCodes;
    }

    private ColorCode GetColorCode(char character)
    {
        ColorCode[] allColorCodes = Enum.GetValues<ColorCode>();
        int i = 0;
        while ((i < allColorCodes.Length - 1) && (allColorCodes[i].GetInitial() != character))
        {
            i++;
        }
        return allColorCodes[i];
    }

    internal void Write(IEnumerable<ColorCode> colorCodes)
    {
        foreach (ColorCode colorCode in colorCodes)
        {
            ConsoleIO.GetInstance().Write(colorCode.GetInitial());
        }
    }
}