using Mastermind.Types;

namespace Mastermind.Models;

internal class ProposedCombination : Combination
{
    public ProposedCombination(List<ColorCode> colorCodes)
    {
        _colorCodes = colorCodes;
    }

    public List<ColorCode> ProposedCombinations => _colorCodes;

    internal ErrorCode GetErrorCodeToProposedCombination()
    {
        if (_colorCodes.Count != Combination.Width)
        {
            return ErrorCode.WrongLength;
        }

        List<ColorCode> colorCodes = new List<ColorCode>();
        for (int i = 0; i < _colorCodes.Count; i++)
        {
            ColorCode colorCode = _colorCodes[i];
            if (colorCode.IsNull())
            {
                return ErrorCode.WrongCharacters;
            }
            for (int j = 0; j < i; j++)
            {
                if (colorCodes[j] == colorCode)
                {
                    return ErrorCode.Duplicated;
                }
            }
            colorCodes.Add(colorCode);
        }
        return ErrorCode.Null;
    }
}