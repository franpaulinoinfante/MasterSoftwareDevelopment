using Mastermind.Models;
using Mastermind.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Controllers;

public class PlayController : Controller
{
    public PlayController(Game game) : base(game)
    {
    }

    public bool IsFinished => _game.IsFinishe;

    public bool IsWinner => _game.IsWinner;


    public void AddProposedCombination(List<ColorCode> colorCodes)
    {
        _game.AddProposedCombination(colorCodes);
    }

    public ErrorCode GetErrorCodeToProposedCombination(List<ColorCode> colorCodes)
    {
        return _game.GetErrorCodeToProposedCombination(colorCodes);
    }

    public void CheckResults()
    {
        _game.CheckResult();
    }
}
