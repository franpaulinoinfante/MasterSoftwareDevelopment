using Mastermind.Types;

namespace Mastermind.Models;

internal class SecrectCombination : Combination
{
    internal void Generate()
    {
        _colorCodes = Enum.GetValues<ColorCode>().ToList();
        _colorCodes.Remove(ColorCode.Null);
        int numberToRemove = _colorCodes.Count - Result.Width;
        Random random = new Random();
        for (int i = 0; i < numberToRemove; i++)
        {
            _colorCodes.Remove(_colorCodes[random.Next(minValue: 0, _colorCodes.Count)]);
        }
        _colorCodes.Reverse();
    }

    internal Result CheckResult(ProposedCombination proposedCombination)
    {
        int blacks = 0;
        int whites = 0;
        for (int i = 0; i < Result.Width; i++)
        {
            if (proposedCombination.Codecolors.ElementAt(i) == _colorCodes[i])
            {
                blacks++;
            }
            if (_colorCodes.Contains(proposedCombination.Codecolors.ElementAt(i)))
            {
                whites++;
            }
        }
        return new Result(blacks, whites - blacks);
    }
}