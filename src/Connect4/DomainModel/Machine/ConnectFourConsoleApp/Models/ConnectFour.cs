using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Models.Types;

namespace ConnectFourConsoleApp.Models;

internal class ConnectFour
{
    private Board _board;
    private Turn _turn;

    public ConnectFour()
    {
        _board = new Board();
        _turn = new Turn(_board);
    }

    internal void Run()
    {
        do
        {
            ConfigurePlayers();
            Start();
            Play();
        } while (IsResume());
    }

    private void Start()
    {
        Message.Titile.WriteLine();
        _board.Write();
    }

    private void ConfigurePlayers()
    {
        int players;
        bool valid = false;
        do
        {
            players = ConsoleIO.Instance.ReadInt(Message.Players.GetMessage());
            if (players >= 0 || players <= PlayerCreator.MaxPlayers)
            {
                valid = true;
            }
        } while (!valid);
        _turn.ConfigurePlayers(players);
    }

    private void Play()
    {
        do
        {
            _turn.Play();
            _board.Write();
        } while (!_board.IsFinished());
        _turn.WriteResult();
    }

    private bool IsResume()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(Message.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            _board.Reset();
        }
        return yesNoDialog.IsAffirmative();
    }
}
