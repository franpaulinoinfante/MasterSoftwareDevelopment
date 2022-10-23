using System.Diagnostics;

namespace Mastermind.Models
{
    internal class Result
    {
        private int _whites;
        private int _blacks;
        
        public Result(int blacks, int whites)
        {
            Debug.Assert(blacks >= 0 && whites >= 0);

            _whites = blacks;
            _blacks = whites;
        }

        public int Whites => _whites;

        public int Blacks => _blacks;

        internal bool IsWinner()
        {
            return _blacks == Combination.Width;
        }
    }
}