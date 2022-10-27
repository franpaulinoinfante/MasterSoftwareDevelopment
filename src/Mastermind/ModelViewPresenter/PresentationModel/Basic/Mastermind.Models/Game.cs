using Mastermind.Types;

namespace Mastermind.Models;

public class Game
{
    private SecrectCombination _secrectCombination;
    private ProposedCombination[] _proposedCombinations;
    private Result[] _result;

    private int _attempts;
    private int _resultCount;
    private const int MaxAttempts = 10;

    public Game()
    {
        _secrectCombination = new SecrectCombination();
        _proposedCombinations = new ProposedCombination[MaxAttempts];
        _result = new Result[MaxAttempts];
        NewGame();
    }

    public int Attempts => _attempts;

    public bool IsFinishe => IsWinner || IsLooser;

    public bool IsWinner => _result[_resultCount - 1].IsWinner;

    private bool IsLooser => _attempts == MaxAttempts;

    public void NewGame()
    {
        for (int i = 0; i < _attempts; i++)
        {
            _proposedCombinations[i] = null;
            _result[i] = null;
        }
        _secrectCombination.Generate();
        _attempts = 0;
        _resultCount = 0;
    }

    public void AddProposedCombination(List<ColorCode> colorCodes)
    {
        _proposedCombinations[_attempts] = new ProposedCombination(colorCodes);
        _attempts++;
    }

    public ErrorCode GetErrorCodeToProposedCombination(List<ColorCode> colorCodes)
    {
        return new ProposedCombination(colorCodes).GetErrorCodeToProposedCombination();
    }

    public void CheckResult()
    {
        _result[_resultCount] = _secrectCombination.CheckResult(_proposedCombinations[_attempts - 1]);
        _resultCount++;
    }

    public IEnumerable<ColorCode> GetProposedCombination(int position)
    {
        return _proposedCombinations[position].ColorCode;
    }

    public int GetBlakcs(int position)
    {
        return _result[position].Blacks;
    }

    public int GetWhites(int position)
    {
        return _result[position].Whites;
    }
}