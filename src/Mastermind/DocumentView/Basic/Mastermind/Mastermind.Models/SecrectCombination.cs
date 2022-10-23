using Mastermind.Types;
using System.Diagnostics;

namespace Mastermind.Models;

internal class SecrectCombination : Combination
{
    protected int _current;

    internal void Generate()
    {
        Random random = new Random();
        Color[] colors = Enum.GetValues<Color>();
        _current = 0;
        while (_current < Combination.Width)
        {
            Color color = colors[random.Next(minValue: 0, colors.Length - 1)];
            if (!Constain(color))
            {
                _colors[_current] = color;
                _current++;
            }
        }
    }

    private bool Constain(Color color)
    {
        int i = 0;
        while (i < Combination.Width && _colors[i] != color)
        {
            i++;
        }
        return i < Combination.Width;
    }

    internal Result CheckResults(ProposedCombination proposedCombinations)
    {
        Debug.Assert(proposedCombinations != null);

        int whites = 0;
        int blacks = 0;
        for (int i = 0; i < Combination.Width; i++)
        {
            if (Constain(proposedCombinations.Colors[i]))
            {
                whites++;
            }
            if (Constain(proposedCombinations.Colors[i], i))
            {
                blacks++;
            }
        }
        return new Result(blacks, whites);
    }

    private bool Constain(Color color, int i)
    {
        return _colors[i] == color;
    }
}