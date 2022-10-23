using Mastermind.Types;
using System.Diagnostics;

namespace Mastermind.Models;

internal class ProposedCombination:Combination
{
    public ProposedCombination(Color[] colors)
    {
        Debug.Assert(colors != null);

        Add(colors);
    }

    internal Color[] Colors => _colors;

    private void Add(Color[] colors)
    {
        Debug.Assert(colors != null);

        for (int i = 0; i < Combination.Width; i++)
        {
            _colors[i] = colors[i];
        }
    }
}