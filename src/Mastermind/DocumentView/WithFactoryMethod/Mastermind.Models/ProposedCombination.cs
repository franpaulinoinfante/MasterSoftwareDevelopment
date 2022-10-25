using Mastermind.Types;

namespace Mastermind.Models
{
    internal class ProposedCombination : Combination
    {
        public ProposedCombination(ColorCode[] colorCodes) : base(colorCodes)
        {
        }

        public ColorCode[] Combination => _colorCodes;

        internal ErrorCode GetErrorCodeToProposedCombination()
        {
            throw new NotImplementedException();
        }
    }
}