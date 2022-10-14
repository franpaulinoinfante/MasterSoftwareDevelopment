using TicTacToe.Types;

namespace TicTacToe.Models;

public class Game
{
    private readonly Board _board;
    private readonly Turn _turn;
    private readonly Player[] _players;

    public Game()
    {
        _board = new Board();
        _players = new Player[Turn.NUM_PLAYERS];
        NewGame();
        _turn = new Turn(_players);
    }

    public void NewGame()
    {
        _board.Reset();
        for (int i = 0; i < Turn.NUM_PLAYERS; i++)
        {
            _players[i] = new Player(Enum.GetValues<Token>()[i], _board);
        }
    }

    public Token CurrentPlayer => _turn.CurrentPlayer.Token;

    public Token GetToken(Coordinate coordinate)
    {
        return _board.GetToken(coordinate);
    }

    public bool IsTicTacToe()
    {
        var result = _board.IsticTacToe(_turn.GetLast().Token);
        return result;
    }

    public Token GetLastTurn()
    {
        return _turn.GetLast().Token;
    }

    public bool AreAllTokenOnBoard()
    {
        return _board.AreAllTokenOnBoard(CurrentPlayer);
    }

    public void Next()
    {
        _turn.Next();
    }

    public void PutToken(Coordinate coordinate)
    {
        _players[(int)CurrentPlayer].PutToken(coordinate);
    }

    public ErrorCode GetErrorCodeToPut(Coordinate coordinate)
    {
        return _board.GetErrorCodeToPut(coordinate);
    }

    public void Move(Coordinate origin, Coordinate target)
    {
        _players[(int)CurrentPlayer].Move(origin, target);
    }

    public ErrorCode GetErrorCodeToMoveOrigin(Coordinate coordinate)
    {
        return _players[(int)CurrentPlayer].GetErrorCodeToMoveOrigin(coordinate);
    }

    public ErrorCode GetErrorCodeToMoveTarget(Coordinate origin, Coordinate target)
    {
        return _board.GetErrorCodeToMoveTarget(origin, target);
    }
}
