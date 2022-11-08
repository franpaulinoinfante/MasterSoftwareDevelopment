using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

internal class PlayController : Controller
{
    public PlayController(Game game) : base(game)
    {
    }

    internal int GetAttempts()
    {
        return _game.Attempts;
    }

    internal void AddproposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        _game.AddProposedCombination(colorCodes);
    }

    internal ErrorCode GetErrorCodeToProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        return _game.GetErrorCodeToProposedCombination(colorCodes);
    }

    internal IEnumerable<ColorCode> GetProposedCombination(int position)
    {
        return _game.GetProposedCombination(position);
    }

    internal void CheckResult()
    {
        _game.CheckResult();
    }

    internal int GetBlacks(int position)
    {
        return _game.GetBlacks(position);
    }

    internal int GetWhites(int position)
    {
        return _game.GetWhites(position);
    }

    internal bool IsFinished()
    {
        return _game.IsFinished();
    }

    internal bool IsWinner()
    {
        return _game.IsWinner();
    }
}
