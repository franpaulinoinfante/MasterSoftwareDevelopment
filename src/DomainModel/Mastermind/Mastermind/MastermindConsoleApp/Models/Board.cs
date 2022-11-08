using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal class Board
{
    private readonly SecrectCombination _secrectCombination;
    private readonly ProposedCombination[] _proposedCombinations;
    private readonly Result[] _results;

    private int _attemps;
    private int _resultsCount;

    private const int TotalAttemps = 4;

    public Board()
    {
        _secrectCombination = new SecrectCombination();
        _proposedCombinations = new ProposedCombination[TotalAttemps];
        _results = new Result[TotalAttemps];
        NewGame();
    }

    internal void NewGame()
    {
        for (int i = 0; i < _attemps; i++)
        {
            _proposedCombinations[i] = null;
            _results[i] = null;
        }
        _attemps = 0;
        _resultsCount = 0;
        _secrectCombination.GenerateSecrectCombination();
    }

    internal void AddProposedCombination(ProposedCombination proposedCombination)
    {
        _proposedCombinations[_attemps] = proposedCombination;
        _attemps++;
    }

    internal void CheckResults()
    {
        _results[_resultsCount] = _secrectCombination.CheckResults(_proposedCombinations[_attemps - 1]);
        _resultsCount++;
    }

    internal bool Finished()
    {
        return IsWinner() || IsLooser();
    }

    private bool IsLooser()
    {
        return _attemps == TotalAttemps;
    }

    internal bool IsWinner()
    {
        return _results[_resultsCount - 1].IsWinner();
    }

    internal void Write()
    {
        Message.Attempts.WriteLine(_attemps);
        _secrectCombination.Write();
        for (int i = 0; i < _attemps; i++)
        {
            _proposedCombinations[i].Write();
            _results[i].WriteLine();
        }
    }
}