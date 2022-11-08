using Connect4.ConsoleIOs;
using Connect4.Models;
using Connect4.Models.Types;

namespace Connect4;

internal class ConnectFour
{
    private readonly Board _board;
    private readonly Turn _turn;

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
        } while (Resume());
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

    private bool Resume()
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
