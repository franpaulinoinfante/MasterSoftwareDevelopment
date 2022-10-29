namespace Mastermind.Models
{
    internal class Result
    {
        private readonly int _blacks;
        private readonly int _whites;

        internal static int Width = 4;

        public Result(int blacks, int whites)
        {
            _blacks = blacks;
            _whites = whites;
        }

        public int Blacks { get => _blacks; }
        public int Whites { get => _whites; }

        internal bool IsWinner()
        {
            return Blacks == Result.Width;
        }
    }
}