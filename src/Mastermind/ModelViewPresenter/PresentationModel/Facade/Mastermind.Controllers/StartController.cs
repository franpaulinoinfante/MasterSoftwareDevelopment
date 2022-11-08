using Mastermind.Models;

namespace Mastermind.Controllers;

internal class StartController : Controller
{
    public StartController(Game game) : base(game)
    {
    }

    internal void NewGame()
    {
        _game.NewGame();
    }
}
