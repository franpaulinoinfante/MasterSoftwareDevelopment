using Mastermind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.ConsoleApp;

internal abstract class WithGameView
{
    protected Game _game;

    protected WithGameView(Game game)
    {
        _game = game;
    }
}
