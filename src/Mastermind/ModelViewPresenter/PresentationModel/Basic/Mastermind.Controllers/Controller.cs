using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.Controllers;

public abstract class Controller
{
    protected internal Game _game;

    public Controller(Game game)
    {
        _game = game;
    }

    public int Attempts => _game.Attempts;

    public IEnumerable<ColorCode> GetProposedCombinations(int position)
    {
        return _game.GetProposedCombination(position);
    }

    public int GetBlacks(int position)
    {
        return _game.GetBlakcs(position);
    }

    public int GetWhites(int position)
    {
        return _game.GetWhites(position);
    }

}
