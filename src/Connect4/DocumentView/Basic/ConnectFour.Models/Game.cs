using ConnectFour.Types;
using ConnectFour.Utils;

namespace ConnectFour.Models;

public class Game
{
    private readonly Board _board;
    private readonly Turn _turn;

    public Game()
    {
        _board = new Board();
        _turn = new Turn(_board);
    }

    public void Reset()
    {
        _board.Reset();
    }

    public void Drop(int colunm)
    {
        _turn.Drop(colunm);
    }

    public Error GetErrorToDrop(int colunm)
    {
        return _turn.GetErrorToDrop(colunm);
    }

    public Error GetErrorToSetNumOfPlayers(int players)
    {
        return _turn.GetErrorToSetNumOfPlayers(players);
    }

    public Token GetActivePlayer()
    {
        return _turn.ActivePlayer;
    }

    public Token GetLastPlayer()
    {
        return _turn.LastPlayer;
    }

    public PlayerType GetPlayerType()
    {
        return _turn.PlayerType;
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _board.GetToken(coordinate);
    }

    public bool IsFinished()
    {
        return _board.IsFinished();
    }

    public bool IsWinner()
    {
        return _board.IsWinner();
    }

    public void Next()
    {
        _turn.Next();
    }

    public void SetPlayer(int players)
    {
        _turn.SetPlayers(players);
    }
}
