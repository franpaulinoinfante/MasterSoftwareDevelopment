using Mastermind.Types;

namespace Mastermind.Models;

internal class ProposedCombination : Combination
{
    public ProposedCombination(IEnumerable<ColorCode> colorCodes) : base(colorCodes)
    {
    }

    public IEnumerable<ColorCode> ProposedCombinations { get => _colorCodes; }

    internal ErrorCode GetErrorCodeToProposedCombination()
    {
        if (_colorCodes.Count() != Result.Width)
        {
            return ErrorCode.WrongLength;
        }

        List<ColorCode> correctColors = new List<ColorCode>();
        for (int i = 0; i < _colorCodes.Count(); i++)
        {
            ColorCode colorCode = _colorCodes.ElementAt(i);
            if (colorCode.IsNull())
            {
                return ErrorCode.WrongCharacters;
            }
            if (correctColors.Contains(colorCode))
            {
                return ErrorCode.Duplicate;
            }
            correctColors.Add(colorCode);
        }
        return ErrorCode.Null;
    }
}