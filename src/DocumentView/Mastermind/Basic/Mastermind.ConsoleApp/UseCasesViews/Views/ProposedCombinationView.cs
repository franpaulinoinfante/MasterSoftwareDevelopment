using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.ConsoleApp.UseCasesViews.Views;
using Mastermind.Models;
using Mastermind.Types;

internal class ProposedCombinationView
{
    internal Color[] Read(Game game)
    {
        Color[] colors;
        Error error;
        do
        {
            string characters = ConsoleIO.GetInstance().ReadString(Message.ProposedCombination.GetString()).ToLower();
            colors = GetColors(characters);
            error = game.CheckErrorsToProposedCombination(colors);
            new ErrorView().WriteLine(error);
        } while (!error.IsNull());
        return colors;
    }

    private Color[] GetColors(string characters)
    {
        Color[] colors = new Color[characters.Length];
        for (int i = 0; i < characters.Length; i++)
        {
            colors[i] = GetColor(characters.ToLower()[i]);
        }
        return colors;
    }

    private Color GetColor(char character)
    {
        Color[] colors = Enum.GetValues<Color>();
        int i = 0;
        while (i < colors.Length && colors[i].GetInitial() != character)
        {
            i++;
        }
        if (i == colors.Length)
        {
            i--;
        }
        return colors[i];
    }

    internal void Write(Color[] colors)
    {
        foreach (Color color in colors)
        {
            new ColorView().Write(color);
        }
    }
}