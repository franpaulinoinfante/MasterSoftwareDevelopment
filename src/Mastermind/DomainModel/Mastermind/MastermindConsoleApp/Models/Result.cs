using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models
{
    internal class Result
    {
        private ProposedCombination _proposedCombination;
        private int _whites;
        private int _blacks;

        private const int Width = 4;

        public Result(ProposedCombination proposedCombination, int whites, int blacks)
        {
            _proposedCombination = proposedCombination;
            _whites = whites;
            _blacks = blacks;
        }

        internal bool IsWinner()
        {
            return _blacks == Width;
        }

        internal void WriteLine()
        {
            MessageType.Results.WriteLine( _blacks, _whites - _blacks);
        }
    }
}