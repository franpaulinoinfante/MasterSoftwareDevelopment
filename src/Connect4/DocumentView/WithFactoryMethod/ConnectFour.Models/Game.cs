using ConnectFour.Types;
using ConnectFour.Utils;

namespace ConnectFour.Models;
public class Game
{
    private readonly Board _board;
    private readonly Player[] _players;
    private readonly Turn _turn;

    public Game()
    {
        _board = new Board();
        _players = new Player[Turn.MaxPlayers];
        _turn = new Turn(_players);
    }

    public void Set(int numOfPlayers)
    {
        for (int i = 0; i < numOfPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board, PlayerType.UserPlayer);
        }
        for (int i = numOfPlayers; i < Turn.MaxPlayers; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board, PlayerType.MachinePlayer);
        }
    }

    public void Drop(int colunm)
    {
        _turn.CurrentPlayer.Drop(colunm);
    }

    public Token GetCurrentTurn()
    {
        return _turn.CurrentPlayer.Token;
    }

    public Error GetErrorToDrop(int colunm)
    {
        return _turn.CurrentPlayer.GetErrorToDrop(colunm);
    }

    public Error GetErrorToSetUpNumOfPlayer(int players)
    {
        return _turn.GetErrorToSetUpNumOfPlayer(players);
    }

    public PlayerType GetPlayerTypeFromTurn()
    {
        return _turn.CurrentPlayer.PlayerType;
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _board.GetToken(coordinate);
    }

    public Token GetWinner()
    {
        return _turn.GetLastPlayer.Token;
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

    public void Reset()
    {
        _board.Reset();
    }
}
