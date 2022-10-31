using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

public class ResumeController : Controller
{
    public ResumeController(Game game, StateCode stateCode) : base(game, stateCode)
    {
    }

    public void NewGame()
    {
        _game.NewGame();
    }

    public override void Accept(IControllerVisitor controllerVisitor)
    {
        controllerVisitor.Visit(this);
    }
}
