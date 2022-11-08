using Mastermind.Types;

namespace Mastermind.Models;

internal class SecrectCombination : Combination
{
    internal void Generate()
    {
        List<ColorCode> colorCodes = Enum.GetValues<ColorCode>().ToList();
        colorCodes.Remove(ColorCode.Null);
        int colorCodesToRemove = colorCodes.Count - Result.Width;
        Random random = new Random();
        for (int i = 0; i < colorCodesToRemove; i++)
        {
            colorCodes.Remove(colorCodes[random.Next(minValue: 0, colorCodes.Count)]);
        }
        _colorCodes = colorCodes;
    }

    internal Result CheckResult(ProposedCombination proposedCombination)
    {
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