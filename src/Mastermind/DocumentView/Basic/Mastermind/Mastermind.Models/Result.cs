using System.Diagnostics;

namespace Mastermind.Models
{
    internal class Result
    {
        private readonly int _whites;
        private readonly int _blacks;

        public Result(int whites, int blacks)
        {
            Debug.Assert(blacks >= 0 && whites >= 0);

            _whites = whites;
            _blacks = blacks;
        }

        internal int Whites => _whites;

        internal int Blacks => _blacks;

        internal bool IsWinner()
        {
            return _blacks == Combination.Width;
        }
    }
}