using Mastermind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.GameViews
{
    public abstract class WithGameView
    {
        protected internal Game _game;

        protected WithGameView(Game game)
        {
            _game = game;
        }
    }
}
