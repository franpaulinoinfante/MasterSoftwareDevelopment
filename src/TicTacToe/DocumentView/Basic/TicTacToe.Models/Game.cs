using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models.Types;

namespace TicTacToe.Models;

public class Game
{
    private Board _board;
    private Turn _turn;
    private Player[] _players;

    public Game()
    {
        _board = new Board();
        _players = new Player[SetUp.NUM_PLAYERS];
        _turn = new Turn(_players); 
    }

    public PlayerType CurrentPlayerType => _turn.CurrentPlayer.PlayerType;

    public void NewGame()
    {
        _turn.NewGame();
        _board.NewGame();
    }

    public bool AreAllTokenOnBoard()
    {
        return _turn.CurrentPlayer.AreAllTokenOnBoard();
    }

    public Token GetToken(Coordinate coordinate)
    {
        return _board.GetToken(coordinate);
    }

    public void SetUpPlayers(int numPlayers)
    {
        for (int i = 0; i < SetUp.NUM_PLAYERS; i++)
        {
            _players[i] = PlayerCreator.GetInstance.GetPlayer(i, numPlayers, _board);
        }
    }

    public bool IsTicTacToe()
    {
        return _board.IsTicTacToe(_turn.LastPlayer.Token);
    }

    public void PutToken(Coordinate coordinate)
    {
        _turn.CurrentPlayer.PutToken(coordinate);
    }

    public ErrorType GetErrorTypeToPut(Coordinate coordinate)
    {
        return _turn.CurrentPlayer.GetErrorTypeToPut(coordinate);
    }

    public void MoveToken(Coordinate origin, Coordinate target)
    {
        _turn.CurrentPlayer.MoveToken(origin, target);
    }

    public ErrorType GetErrorTypeToMoveOrigin(Coordinate coordinate)
    {
        return _turn.CurrentPlayer.GetErrorTypeToMoveOrigin(coordinate);
    }

    public ErrorType GetErrorTypeToMoveTarge(Coordinate origin, Coordinate coordinate)
    {
        return _turn.CurrentPlayer.GetErrorTypeToMoveTarget(origin, coordinate);
    }

    public void Next()
    {
        _turn.Next();
    }
}
