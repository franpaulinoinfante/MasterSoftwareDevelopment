new TicTacToe().Start();

internal class TicTacToe
{
    private readonly Board _board;
    private readonly Player[] _players;
    private readonly Turn _turn;

    public TicTacToe()
    {
        _board = new Board();
        _players = new Player[Turn.NUM_PLAYERS];
        _turn = new Turn(_players, _board);
    }

    internal void Start()
    {
        do
        {
            new Message(MessageType.TITLE).WriteLine();
            _board.Write();
            Play();
        } while (Resume());
    }

    private void Play()
    {
        bool isTicTacToe;
        do
        {
            if (!_board.AreAllTokenOnBoard(_players[_turn.Current].Token))
            {
                _players[_turn.Current].PutToken();
            }
            else
            {
                _players[_turn.Current].MoveToken();
            }
            _board.Write();
            isTicTacToe = _board.IsticTacToe(_players[_turn.Current].Token);
            _turn.Next();
        } while (!isTicTacToe);
        new Message(MessageType.WINNER).WriteLine(_players[_turn.Last].Token.ToString());
    }

    private bool Resume()
    {
        bool resume = _players[_turn.Current].Resume();
        if (resume)
        {
            NewGame();
        }
        return resume;
    }

    private void NewGame()
    {
        _board.NewGame();
        _turn.NewGame(_board);
    }
}