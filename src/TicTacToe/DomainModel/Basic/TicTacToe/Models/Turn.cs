internal class Turn
{
    public static int NUM_PLAYERS = 2;

    private readonly Player[] _players;
    private int _current;

    public Turn(Player[] players, Board _board)
    {
        _players = players;
        NewGame(_board);
    }

    public int Current => _current;

    public int Last => Change();

    internal void NewGame(Board board)
    {
        for (int i = 0; i < NUM_PLAYERS; i++)
        {
            _players[i] = new Player(Enum.GetValues<TokenType>()[i], board);
        }
        _current = new Random().Next(NUM_PLAYERS);
    }

    internal void Next()
    {
        _current = Change();
    }
    private int Change()
    {
        return (_current + 1) % NUM_PLAYERS;
    }
}