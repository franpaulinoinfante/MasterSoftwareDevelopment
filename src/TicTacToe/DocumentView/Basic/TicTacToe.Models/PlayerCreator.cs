﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Models.Types;

namespace TicTacToe.Models;

internal class PlayerCreator
{
    private static PlayerCreator _instance;

    internal static PlayerCreator GetInstance
    {
        get 
        {
            if (_instance == null)
            {
                return new PlayerCreator();
            }
            return _instance;
        }
    }

    internal Player GetPlayer(int position, int numPlayers, Board board)
    {
        if (position<numPlayers)
        {
            return new UserPlayer(Enum.GetValues<Token>()[position], board);
        }
        else
        {
            return new MachinePlayer(Enum.GetValues<Token>()[position], board);
        }
    }
}
