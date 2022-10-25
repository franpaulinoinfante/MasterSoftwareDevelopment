using Mastermind.Types;

namespace Mastermind.Models
{
    internal class Combination
    {
        protected ColorCode[] _colorCodes;
        protected int _colorCodesCount;

        protected const int Width = 4;

        public Combination()
        {
            _colorCodes = new ColorCode[Width];
            _colorCodesCount = 0;
        }

        public Combination(ColorCode[] colorCodes)
        {
            _colorCodes = colorCodes;
            _colorCodesCount = colorCodes.Length;
        }
    }
}