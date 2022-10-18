using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class Turn
{
    protected Player[] _players;
    protected int _current;

    public Turn(Player[] players)
    {
        _players = players;
        _current = Random();
    }

    internal Player CurrentPlayer => _players[_current];

    internal Player LastPlayer => _players[Change()];

    internal void Next()
    {
        _current = Change();
    }

    private int Change()
    {
        return (_current + 1) % 2; 
    }

    private int Random()
    {
        return new Random().Next(minValue: 0, SetUp.NUM_PLAYERS);
    }

    internal void NewGame()
    {
        _current = Random();
    }
}
