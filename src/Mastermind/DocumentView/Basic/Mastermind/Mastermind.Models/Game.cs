using Mastermind.Types;
using System.Diagnostics;

namespace Mastermind.Models;

public class Game
{
    private readonly SecrectCombination _secrectCombination;
    private readonly ProposedCombination[] _proposedCombinations;
    private readonly Result[] _results;

    private int _attempts;
    private int _resultCount;
    private const int MaxAttempts = 10;

    public Game()
    {
        _secrectCombination = new SecrectCombination();
        _proposedCombinations = new ProposedCombination[MaxAttempts];
        _results = new Result[MaxAttempts];
        NewGame();
    }

    public int Attemps => _attempts;

    public void NewGame()
    {
        _secrectCombination.Generate();

        if (_attempts > 0)
        {
            for (int i = 0; i < _attempts; i++)
            {
                _proposedCombinations[i] = null;
                _results[i] = null;
            }
        }
        _attempts = 0;
        _resultCount = 0;
    }

    public int GetWhites(int position)
    {
        Debug.Assert(position >= 0);

        return _results[position].Whites;
    }

    public int GetBlacks(int position)
    {
        Debug.Assert(position >= 0);

        return _results[position].Blacks;
    }

    public Color[] GetProposedCombination(int position)
    {
        Debug.Assert(position >= 0);

        return _proposedCombinations[position].Colors;
    }

    public void Add(Color[] colors)
    {
        Debug.Assert(colors != null);

        _proposedCombinations[_attempts] = new ProposedCombination(colors);
        _attempts++;
    }

    public void CheckResult()
    {
        _results[_resultCount] = _secrectCombination.CheckResults(_proposedCombinations[_attempts - 1]);
        _resultCount++;
    }

    public bool IsFinished()
    {
        return isWinner() || IsLooser();
    }

    public bool isWinner()
    {
        return _results[_resultCount - 1].IsWinner();
    }

    public bool IsLooser()
    {
        return _attempts == MaxAttempts;
    }

    public Error CheckErrorsToProposedCombination(Color[] colors)
    {
        return new ProposedCombination().CheckErrorsToProposedCombination(colors);
    }
}
