using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

public abstract class Controller
{
    protected Game _game;
    private readonly StateCode _stateCode;

    protected Controller(Game game, StateCode stateCode)
    {
        _game = game;
        _stateCode = stateCode;
    }

    public int GetAttempts()
    {
        return _game.Attempts;
    }

    public IEnumerable<ColorCode> GetProposedCombination(int position)
    {
        return _game.GetProposedCombination(position);
    }

    public int GetBlacks(int position)
    {
        return _game.GetBlacks(position);
    }

    public int GetWhites(int position)
    {
        return _game.GetWhites(position);
    }

    public void NextState()
    {
        _game.NextState();
    }
}
