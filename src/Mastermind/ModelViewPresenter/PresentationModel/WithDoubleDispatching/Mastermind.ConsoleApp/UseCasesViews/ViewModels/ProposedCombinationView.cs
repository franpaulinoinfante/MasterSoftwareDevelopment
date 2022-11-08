using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.Controllers;
using Mastermind.GameViews;
using Mastermind.Types;

internal class ProposedCombinationView
{
    internal IEnumerable<ColorCode> Read(PlayController playController)
    {
        IEnumerable<ColorCode> colorCodes;
        ErrorCode errorCode;
        do
        {
            string characters = ConsoleIO.GetInstance().ReadString(MessageCode.ProposedCombination.GetMessage()).ToLower();
            colorCodes = GetColorCodes(characters);
            errorCode = playController.GetErrorCodeToProposedCombination(colorCodes);
            new Mastermind.ConsoleApp.UseCasesViews.ViewModels.ErrorView().WriteLine(errorCode);
        } while (!errorCode.IsNull());
        return colorCodes;
    }

    private IEnumerable<ColorCode> GetColorCodes(string characters)
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
        List<ColorCode> colorCodes = Enum.GetValues<ColorCode>().ToList();
        int i = 0;
        while ((i < colorCodes.Count() - 1) && (colorCodes[i].GetInitial() != character))
        {
            i++;
        }
        return colorCodes[i];
    }

    internal void Write(IEnumerable<ColorCode> colorCodes)
    {
        ConsoleIO.GetInstance().Write(colorCodes.ToList().GetInitials());
    }
}