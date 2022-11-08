using Mastermind.Models;

namespace Mastermind.Controllers;

public class ResumeController : Controller
{
    public ResumeController(Game game) : base(game)
    {
    }

    public void NewGame()
    {
        _game.NewGame();
    }
}
