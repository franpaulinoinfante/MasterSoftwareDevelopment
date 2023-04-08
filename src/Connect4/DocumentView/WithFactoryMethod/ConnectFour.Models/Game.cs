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

    private Player CurrentPlayer => _turn.CurrentPlayer;

    public void NewGame()
    {
        _board.NewGame();
    }

    public void SetPlayer(int numOfPlayers)
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

    public Error GetErrorToSetUpNumOfPlayer(int players)
    {
        return _turn.GetErrorToSetUpNumOfPlayer(players);
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _board.GetToken(coordinate);
    }

    public PlayerType GetPlayerTypeFromTurn()
    {
        return CurrentPlayer.PlayerType;
    }

    public Token GetCurrentTurn()
    {
        return CurrentPlayer.Token;
    }

    public void Drop(int column)
    {
        CurrentPlayer.Drop(column);
    }

    public Error GetErrorToDrop(int column)
    {
        return CurrentPlayer.GetErrorToDrop(column);
    }

    public void Next()
    {
        _turn.Next();
    }

    public bool IsFinished()
    {
        return _board.IsFinished();
    }

    public bool IsWinner()
    {
        return _board.IsWinner();
    }

    public Token GetWinnerPlayer()
    {
        return _turn.GetLastPlayer.Token;
    }
}
