using Mastermind.Types;
using System.Diagnostics;

namespace Mastermind.Models;

internal class ProposedCombination : Combination
{
    public ProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        _colorCodes = colorCodes;
    }

    public IEnumerable<ColorCode> ProposedCombinations => _colorCodes;

    internal ErrorCode GetErrorCodeToProposedCombination()
    {
        Debug.Assert(_colorCodes != null);

        if (_colorCodes.Count() > Result.Width)
        {
            return ErrorCode.WrongLength;
        }

        List<ColorCode> correctColorCodes = new List<ColorCode>();
        foreach (ColorCode colorCode in _colorCodes)
        {
            if (colorCode.IsNull())
            {
                return ErrorCode.WrongCharacters;
            }
            if (correctColorCodes.Contains(colorCode))
            {
                return ErrorCode.Duplicate;
            }
            correctColorCodes.Add(colorCode);
        }
        return ErrorCode.Null;
    }
}