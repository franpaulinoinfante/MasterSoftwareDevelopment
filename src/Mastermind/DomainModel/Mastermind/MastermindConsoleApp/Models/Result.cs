using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models
{
    internal class Result
    {
        private int _whites;
        private int _blacks;

        private const int Width = 4;

        public Result(int whites, int blacks)
        {
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