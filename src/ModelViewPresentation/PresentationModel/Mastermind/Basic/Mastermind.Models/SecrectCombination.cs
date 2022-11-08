using Mastermind.Types;

namespace Mastermind.Models;

internal class SecrectCombination : Combination
{
    internal void Generate()
    {
        _colorCodes = Enum.GetValues<ColorCode>().ToList();
        _colorCodes.Remove(ColorCode.Null);
        int numberOfRemove = _colorCodes.Count - Result.Width;
        Random random = new Random();
        for (int i = 0; i < numberOfRemove; i++)
        {
            _colorCodes.Remove(_colorCodes[random.Next(_colorCodes.Count)]);
        }
        _colorCodes.Reverse();
    }

    internal Result CheckResult(ProposedCombination proposedCombination)
    {
        int blakcs = 0;
        int whites = 0;
        for (int i = 0; i < Result.Width; i++)
        {
            if (proposedCombination.ColorCode[i] == _colorCodes[i])
            {
                blakcs++;
            }
            if (_colorCodes.Contains(proposedCombination.ColorCode.ElementAt(i)))
            {
                whites++;
            }
        }
        return new Result(blakcs, whites - blakcs);
    }
}