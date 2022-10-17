namespace TicTacToe.Models
{
    internal class Turn
    {
        internal static int NUM_PLAYERS = 2;
        private readonly Player[] _players;
        private int _current;

        public Turn(Player[] players, Board board)
        {
            _players = players;
            _current = 0;
        }

        public int Current => _current;

        internal void SetUpPlayers(int numberUsers, Board board)
        {
            for (int i = 0; i < NUM_PLAYERS; i++)
            {
                _players[i] = UserCreator.GetInstante().GetUser(i, numberUsers, board);
            }
        }

        internal void Next()
        {
            _current = Change();
        }

        private int Change()
        {
            return (_current + 1) % Turn.NUM_PLAYERS;
        }
    }
}