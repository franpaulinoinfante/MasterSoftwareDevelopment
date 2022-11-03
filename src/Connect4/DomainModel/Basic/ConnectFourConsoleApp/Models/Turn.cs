internal class Turn
{
    public static int Players = 2;

    private Player[] _players;
    private int _current;

    public Turn(Player[] players)
    {
        _players = players;
        Reset();
    }

    public Player CurrentPlayer => _players[_current];

    public Player LastPlayer => _players[Change()];

    private int Change()
    {
        return (_current + 1) % Turn.Players;
    }

    internal void Next()
    {
        _current = Change();
    }

    internal void Reset()
    {
        _current = new Random().Next(minValue: 0, Turn.Players);
    }
}