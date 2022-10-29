using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

public class PlayController : Controller
{
    public PlayController(Game game, StateCode stateCode) : base(game, stateCode)
    {
    }

    public void AddProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        _game.AddProposedCombination(colorCodes);
    }

    public ErrorCode GetErrorCodeToProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        return _game.GetErrorCodeToProposedCombination(colorCodes);
    }

    public void CheckResult()
    {
        _game.CheckResult();
    }

    public bool IsFinished()
    {
        return _game.IsFinished();
    }

    public bool IsWinner()
    {
        return _game.IsWinner();
    }
}
