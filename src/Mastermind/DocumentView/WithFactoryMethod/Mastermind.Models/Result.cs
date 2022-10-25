namespace Mastermind.Models
{
    internal class Result
    {
        public int Blacks { get; internal set; }
        public int Whites { get; internal set; }

        internal bool IsWinner()
        {
            throw new NotImplementedException();
        }
    }
}