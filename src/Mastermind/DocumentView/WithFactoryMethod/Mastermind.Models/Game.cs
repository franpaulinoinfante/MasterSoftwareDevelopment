using Mastermind.Types;

namespace Mastermind.Models;

public class Game
{
	private SecrectCombination _secrectCombination;
	private ProposedCombination[] _proposedCombinations;
	private Result[] _results;

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

	public void NewGame()
    {
        _secrectCombination.Generate();
        for (int i = 0; i < _attempts; i++)
        {
            _proposedCombinations[i] = null;
            _results[i] = null;
        }
        _attempts = Initial;
		_resultCount = Initial;
	}

	public void AddProposeCombination(ColorCode[] colorCodes)
	{
		_proposedCombinations[_attempts] = new ProposedCombination(colorCodes);
		_attempts++;
	}

	public ErrorCode GetErrorCodeToProposedCombination(ColorCode[] colorCodes)
	{
		return new ProposedCombination(colorCodes).GetErrorCodeToProposedCombination();
    }

	public void CheckResult()
	{
		_results[_resultCount] = _secrectCombination.CheckResult(_proposedCombinations[_attempts - 1]);
		_resultCount++;
	}

	public ColorCode[] GetProposedCombination(int position)
	{
		return _proposedCombinations[position].Combination;
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

	private bool IsWinner()
	{
		return _results[_resultCount - 1].IsWinner();
	}

	private bool IsLooser()
	{
		return _attempts == MaxAttempts;
	}
}
