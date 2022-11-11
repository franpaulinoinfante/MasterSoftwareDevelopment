using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Types;

namespace ConnectFourConsoleApp.Models;

internal class ConnectFour
{
    private readonly Board _board;
    private readonly Turn _turn;

    public ConnectFour()
    {
        _board = new Board();
        _turn = new Turn(_board);
    }

    internal void Init()
    {
        do
        {
            SetUp();
            Start();
            Play();
        } while (IsResume());
    }

    private void SetUp()
    {
        int players;
        bool valid = false;
        do
        {
            players = ConsoleIO.Instance.ReadInt(Message.NumOfPlayers.GetMessage());
            if (players >= 0 || players <= Turn.MaxPlayers)
            {
                valid = true;
            }
        } while (!valid);
        _turn.SetUp(players);
    }

    private void Start()
    {
        Message.Titile.WriteLine();
        _board.Write();
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
