using Mastermind.Types;

namespace Mastermind.Models;

public class Game
{
    private readonly SecrectCombination _secrectCombination;
    private readonly ProposedCombination[] _proposedCombination;
    private readonly Result[] _results;
    private readonly State _state;

    private int _attempts;
    private int _resultCount;

    private const int Initial = 0;
    private const int MaxAttempts = 10;

    public Game()
    {
        _secrectCombination = new SecrectCombination();
        _proposedCombination = new ProposedCombination[Game.MaxAttempts];
        _results = new Result[Game.MaxAttempts];
        _state = new State();
    }

    public void NewGame()
    {
        for (int i = 0; i < _attempts; i++)
        {
            _proposedCombination[i] = null;
            _results[i] = null;
        }
        _secrectCombination.Generate();
        _state.Reset();
        _attempts = Game.Initial;
        _resultCount = Game.Initial;
    }

    public int Attempts => _attempts;
    public StateCode StateCode => _state.StateCode;

    public void ResetSate()
    {
        _state.Reset();
    }

    public void NextState()
    {
        _state.Next();
    }

    public void AddProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        _proposedCombination[_attempts] = new ProposedCombination(colorCodes);
        _attempts++;
    }

    public ErrorCode GetErrorCodeToProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        return new ProposedCombination(colorCodes).GetErrorCodeToProposedCombination();
    }

    public void CheckResult()
    {
        _results[_resultCount] = _secrectCombination.CheckResult(_proposedCombination[_attempts - 1]);
        _resultCount++;
    }

    public IEnumerable<ColorCode> GetProposedCombination(int position)
    {
        return _proposedCombination[position].ProposedCombinations;
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

    private bool IsLooser()
    {
        return _attempts == Game.MaxAttempts;
    }
}
