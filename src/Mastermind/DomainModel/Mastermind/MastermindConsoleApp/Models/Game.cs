using MastermindConsoleApp.ConsolesIOs;
using MastermindConsoleApp.Models.Types;

namespace MastermindConsoleApp.Models;

internal class Game
{
    private readonly Board _board;

    public Game()
    {
        _board = new Board();
    }

    internal void Start()
    {
        do
        {
            MessageType.Title.WriteLine();
            Play();
        } while (Resume());
    }

    private void Play()
    {
        _board.Write();
        do
        {
            _board.AddProposedCombination(Read());
            _board.CheckResults();
            _board.Write();
        } while (_board.Finished());
        Write();
    }

    private ProposedCombination Read()
    {
        return new ProposedCombination().Read();
    }

    private bool Resume()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(MessageType.Resume.ToString());
        if (yesNoDialog.IsAffirmative())
        {
            NewGame();
        }
        return yesNoDialog.IsAffirmative();
    }

    private void NewGame()
    {
        _board.NewGame();
    }

    private void Write()
    {
        if (_board.IsWinner())
        {
            MessageType.Winner.WriteLine();
        }
        MessageType.Looser.WriteLine();
    }
}
