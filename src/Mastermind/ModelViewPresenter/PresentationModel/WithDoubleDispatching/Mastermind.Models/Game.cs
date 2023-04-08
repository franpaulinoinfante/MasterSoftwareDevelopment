using Mastermind.Types;
using System.Diagnostics;

namespace Mastermind.Models;

public class Game
{
    private const int Initial = 0;
    private const int MaxAttempts = 10;

    private readonly SecrectCombination _secretCombination;
    private readonly ProposedCombination[] _proposedCombinations;
    private readonly Result[] _results;
    private readonly State _state;

    private int _attempts;
    private int _resultCount;

    public Game()
    {
        _secretCombination = new SecrectCombination();
        _proposedCombinations = new ProposedCombination[MaxAttempts];
        _results = new Result[MaxAttempts];
        _state = new State();
        NewGame();
    }

    public int Attempts => _attempts;

    public void NewGame()
    {
        Array.Clear(_proposedCombinations);
        Array.Clear(_results);

        //for (int i = 0; i < _attempts; i++)
        //{

        //    _proposedCombinations[i] = null;
        //    _results[i] = null;
        //}

        _attempts = Initial;
        _resultCount = Initial;
        _state.Reset();
        _secretCombination.Generate();
    }

    public StateCode GetStateCode()
    {
        return _state.StateCode;
    }

    public void ResetStateCode()
    {
        _state.Reset();
    }

    public void NextStateCode()
    {
        _state.Next();
    }

    public void AddProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        Debug.Assert(colorCodes != null);

        _proposedCombinations[_attempts] = new ProposedCombination(colorCodes);
        _attempts++;
    }

    public ErrorCode GetErrorCodeToProposedCombination(IEnumerable<ColorCode> colorCodes)
    {
        Debug.Assert(colorCodes != null);

        return new ProposedCombination(colorCodes).GetErrorCodeToProposedCombination();
    }

    public void CheckResult()
    {
        Debug.Assert(_attempts >= 0);

        _results[_resultCount] = _secretCombination.CheckResult(_proposedCombinations[_attempts - 1]);
        _resultCount++;
    }

    public IEnumerable<ColorCode> GetProposedCombination(int position)
    {
        Debug.Assert(position >= 0);

        return _proposedCombinations[position].ProposedCombinations;
    }

    public int GetBlacks(int position)
    {
        Debug.Assert(position >= 0);

        return _results[position].Blacks;
    }

    public int GetWhites(int position)
    {
        Debug.Assert(position >= 0);

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