using Mastermind.Types;

namespace Mastermind.Models;

internal class SecrectCombination : Combination
{
    internal void Generate()
    {
        _colorCodes = Enum.GetValues<ColorCode>().ToList();
        _colorCodes.Remove(ColorCode.Null);
        int numberOfColorToRemove = _colorCodes.Count - Combination.Width;
        Random random = new Random();
        for (int i = 0; i < numberOfColorToRemove; i++)
        {
            _colorCodes.Remove(_colorCodes[random.Next(_colorCodes.Count)]);
        }
        _colorCodes.Reverse();
    }

    internal Result CheckResult(ProposedCombination proposedCombination)
    {
        int blacks = 0;
        int whites = 0;
        for (int i = 0; i < _colorCodes.Count; i++)
        {
            if (_colorCodes.Contains(proposedCombination.ProposedCombinations[i]))
            {
                whites++;
            }
            if (_colorCodes[i] == proposedCombination.ProposedCombinations[i])
            {
                blacks++;
            }
        }
        return new Result(blacks, whites - blacks);
    }
}