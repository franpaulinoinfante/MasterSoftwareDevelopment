using MastermindConsoleApp.Models.Types;
using System.Reflection.Metadata;

namespace MastermindConsoleApp.Models;

internal class Board
{
    private SecrectCombination _secrectCombination;
    private ProposedCombination[] _proposedCombinations;
    private Result[] _results;

    private const int TotalAttemps = 10;
    private int _attemps;
    private int _resultsCount;

    public Board()
    {
        _proposedCombinations = new ProposedCombination[TotalAttemps];
        _results = new Result[TotalAttemps];
        NewGame();
    }

    internal void NewGame()
    {
        _secrectCombination = new SecrectCombination();
        _attemps = 0;
        _resultsCount = 0;

    }

    internal void AddProposedCombination(ProposedCombination proposedCombination)
    {
        _proposedCombinations[_attemps] = proposedCombination;
        _attemps++;
    }

    internal void CheckResults()
    {
        _results[_resultsCount] = _secrectCombination.GetResult(_proposedCombinations[_attemps]);
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
        return _results[_resultsCount].IsWinner();
    }

    internal void Write()
    {
        _secrectCombination.Write();
        for (int i = 0; i < _attemps; i++)
        {
            _proposedCombinations[i].Write();
            _results[i].WriteLine();
        }
    }
}