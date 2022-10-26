using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCaseViews.UseCaseHelpsViews;

internal class ProposedCombinationView : WithGameView
{
    public ProposedCombinationView(Game game) : base(game)
    {
    }

    internal List<ColorCode> Read()
    {
        List<ColorCode> colorCodes;
        ErrorCode errorCode;
        do
        {
            string characters = ConsoleIO.GetInstance().ReadString(MessageCode.ProposedCombination.GetString());
            colorCodes = GetColorCodes(characters);
            errorCode = _game.GetErrorCodeToProposedCombination(colorCodes);
            new ErrorView().WriteLine(errorCode);
        } while (!errorCode.IsNull());
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
        ColorCode[] allColor = Enum.GetValues<ColorCode>();
        int i = 0;
        while (i < allColor.Length - 1 && new ColorCodeView().GetInitital(allColor[i]) != character)
        {
            i++;
        }
        return allColor[i];
    }

    internal void Write(int position)
    {
        List<ColorCode> colorCodes = _game.GetProposedCombination(position);
        foreach (ColorCode colorCode in colorCodes)
        {
            new ColorCodeView().Write(colorCode);
        }
    }
}