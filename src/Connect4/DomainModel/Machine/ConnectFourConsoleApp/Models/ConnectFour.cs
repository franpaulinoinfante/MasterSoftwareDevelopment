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
            Start();
            Play();
        } while (IsResume());
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
            _turn.Reset();
        }
        return yesNoDialog.IsAffirmative();
    }
}
