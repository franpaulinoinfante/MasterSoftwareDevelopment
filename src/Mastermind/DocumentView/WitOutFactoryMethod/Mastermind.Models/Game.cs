using Mastermind.Types;

namespace Mastermind.Models;

public class Game
{
    private readonly SecrectCombination _secrectCombination;
    private readonly ProposedCombination[] _proposedCombinations;
    private readonly Result[] _results;

    private int _attempts;
    private int _resultCount;

    private const int Initial = 0;
    private const int MaxAttempts = 10;

    public Game()
    {
        _secrectCombination = new SecrectCombination();
        _proposedCombinations = new ProposedCombination[MaxAttempts];
        _results = new Result[MaxAttempts];
        NewGame();
    }

    public int Attempts => _attempts;

    public void NewGame()
    {
        if (_attempts > Initial)
        {
            for (int i = 0; i < _attempts; i++)
            {
                _proposedCombinations[i] = null;
                _results[i] = null;
            }
        }
        _attempts = Initial;
        _resultCount = Initial;
        _secrectCombination.Generate();
    }

    public void AddProposedCombination(ColorCode[] colorCodes)
    {
        _proposedCombinations[_attempts] = new ProposedCombination(colorCodes);
        _attempts++;
    }

    public ErrorCode GetErrorCodeToProposedCombination(ColorCode[] colorCode)
    {
        return new ProposedCombination(colorCode).GetErrorCodeToProposedCombination();
    }

    public void CheckResult()
    {
        _results[_resultCount] = _secrectCombination.CheckResult(_proposedCombinations[_attempts - 1]);
        _resultCount++;
    }

    public ColorCode[] GetProposedCombination(int position)
    {
        return _proposedCombinations[position].ColorCodes;
    }

    public int GetBlacks(int position)
    {
        return _results[position].Blacks;
    }

    public int GetWhites(int position)
    {
        return _results[position].Whites;
    }

    public bool IsFinished()
    {
        return IsWinner() || IsLooser();
    }

    public bool IsWinner()
    {
        return _results[_resultCount - 1].IsWinner();
    }

    public bool IsLooser()
    {
        return _attempts == MaxAttempts;
    }
}
