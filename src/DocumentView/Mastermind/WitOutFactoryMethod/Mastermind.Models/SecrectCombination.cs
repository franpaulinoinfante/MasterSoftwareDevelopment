using Mastermind.Types;

namespace Mastermind.Models;

internal class SecrectCombination : Combination
{
    public SecrectCombination() : base()
    {

    }

    internal void Generate()
    {
        ColorCode[] allColorCode = Enum.GetValues<ColorCode>();
        Random random = new Random();
        do
        {
            ColorCode colorCode = allColorCode[random.Next(minValue: 0, allColorCode.Length - 1)];
            if (!Constains(colorCode))
            {
                _colorCodes[_index] = colorCode;
                _index++;
            }
        } while (_index < Combination.Width);
    }

    private bool Constains(ColorCode colorCode)
    {
        for (int i = 0; i < Combination.Width; i++)
        {
            if (_colorCodes[i] == colorCode)
            {
                return true;
            }
        }
        return false;
    }

    internal Result CheckResult(ProposedCombination proposedCombination)
    {
        int whites = 0;
        int blacks = 0;
        for (int i = 0; i < Combination.Width; i++)
        {
            if (Constains(proposedCombination.ColorCodes[i]))
            {
                whites++;
            }
            if (Constains(proposedCombination.ColorCodes[i], i))
            {
                blacks++;
            }
        }
        return new Result(blacks, whites - blacks);
    }

    private bool Constains(ColorCode colorCode, int position)
    {
        return _colorCodes[position] == colorCode;
    }
}