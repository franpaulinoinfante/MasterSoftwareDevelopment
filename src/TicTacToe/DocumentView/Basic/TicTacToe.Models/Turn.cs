namespace TicTacToe.Models
{
    internal class Turn
    {
        internal static int NUM_PLAYERS = 2;
        private readonly Player[]? _players;
        private int _current;

        public Turn(Player[]? players)
        {
            _players = players;
            _current = 0;
        }

        internal Player CurrentPlayer => _players[_current];

        internal void Next()
        {
            _current = (_current + 1) % Turn.NUM_PLAYERS;
        }
    }
}