using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

public class StartController : Controller
{
    public StartController(Game game, StateCode stateCode) : base(game, stateCode)
    {
    }

    public void NewGame()
    {
        _game.NewGame();
    }
}
