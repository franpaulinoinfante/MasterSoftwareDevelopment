using Mastermind.Models;

namespace Mastermind.Controllers;

internal abstract class Controller
{
    protected Game _game;

    protected Controller(Game game)
    {
        _game = game;
    }
}
