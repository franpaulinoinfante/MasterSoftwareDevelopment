using Mastermind.Types;
using System.Diagnostics;

namespace Mastermind.Models;

internal class ProposedCombination : Combination
{
    public ProposedCombination(){ }

    public ProposedCombination(Color[] colors)
    {
        Debug.Assert(colors != null);

        Add(colors);
    }

    internal Color[] Colors => _colors;
    
    internal Error CheckErrorsToProposedCombination(Color[] colors)
    {
        if (colors.Length != Combination.Width)
        {
            return Error.WrongLength;
        }

        Color[] correctColors = new Color[colors.Length];
        for (int i = 0; i < colors.Length; i++)
        {
            Color color = colors[i];
            if (color.IsNull())
            {
                return Error.WrongCharacters;
            }
            for (int j = 0; j < i; j++)
            {
                if (correctColors[j] == color)
                {
                    return Error.Duplicated;
                }
            }
            correctColors[i] = color;        
        }
        return Error.Null;
    }

    private void Add(Color[] colors)
    {
        Debug.Assert(colors != null);

        for (int i = 0; i < Combination.Width; i++)
        {
            _colors[i] = colors[i];
        }
    }
}