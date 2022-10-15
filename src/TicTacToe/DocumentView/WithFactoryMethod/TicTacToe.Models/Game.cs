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

    private Player CurrentPlayer => _turn.CurrentPlayer;

    public Token GetCurrentPlayer()
    {
        return CurrentPlayer.Token;
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _board.GetToken(coordinate);
    }

    public bool IsTicTacToe()
    {
        var result = _board.IsticTacToe(CurrentPlayer.Token);
        return result;
    }

    public bool AreAllTokenOnBoard()
    {
        return _board.AreAllTokenOnBoard(CurrentPlayer.Token);
    }

    public void Next()
    {
        _turn.Next();
    }

    public void PutToken(Coordinate coordinate)
    {
        _players[(int)CurrentPlayer.Token].PutToken(coordinate);
    }

    public ErrorType GetErrorCodeToPut(Coordinate coordinate)
    {
        return _board.GetErrorCodeToPut(coordinate);
    }

    public void Move(Coordinate origin, Coordinate target)
    {
        _players[(int)CurrentPlayer.Token].Move(origin, target);
    }

    public ErrorType GetErrorCodeToMoveOrigin(Coordinate coordinate)
    {
        return _players[(int)CurrentPlayer.Token].GetErrorCodeToMoveOrigin(coordinate);
    }

    public ErrorType GetErrorCodeToMoveTarget(Coordinate origin, Coordinate target)
    {
        return _board.GetErrorCodeToMoveTarget(origin, target);
    }
}
