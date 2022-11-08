using Mastermind.Types;

namespace Mastermind.Models;

internal class ProposedCombination : Combination
{
    public ProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        _colorCodes = colorCodes.ToList();
    }

    public IEnumerable<ColorCode> Codecolors => _colorCodes;

    internal ErrorCode GetErrorCodeToProposedCombination()
    {
        if (_colorCodes.Count > Result.Width)
        {
            return ErrorCode.WrongLength;
        }

        List<ColorCode> allColorCodes = new List<ColorCode>();
        for (int i = 0; i < _colorCodes.Count; i++)
        {
            ColorCode colorCode = _colorCodes[i];
            if (colorCode.IsNull())
            {
                return ErrorCode.WrongCharacters;
            }
            if (allColorCodes.Contains(colorCode))
            {
                return ErrorCode.Duplicated;
            }
            allColorCodes.Add(colorCode);
        }
        return ErrorCode.Null;
    }
}