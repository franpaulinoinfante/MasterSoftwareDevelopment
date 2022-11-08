using Mastermind.Types;
using System.Diagnostics;

namespace Mastermind.Models;

internal class SecrectCombination : Combination
{
    internal void Generate()
    {
        List<ColorCode> colorCodes = Enum.GetValues<ColorCode>().ToList();
        colorCodes.Remove(ColorCode.Null);
        int colorCodeToRemove = colorCodes.Count - Result.Width;
        Random random = new Random();
        for (int i = 0; i < colorCodeToRemove; i++)
        {
            colorCodes.Remove(colorCodes[random.Next(minValue: 0, colorCodes.Count)]);
        }
        colorCodes.Sort();
        colorCodes.Reverse();
        _colorCodes = colorCodes;
    }

    internal Result CheckResult(ProposedCombination proposedCombination)
    {
        Debug.Assert(proposedCombination != null);

        int blacks = 0;
        int whites = 0;
        for (int i = 0; i < Result.Width; i++)
        {
            if (_colorCodes.ElementAt(i) == proposedCombination.ProposedCombinations.ElementAt(i))
            {
                blacks++;
            }
            if (_colorCodes.Contains(proposedCombination.ProposedCombinations.ElementAt(i)))
            {
                whites++;
            }
        }
        return new Result(blacks, whites - blacks);
    }
}