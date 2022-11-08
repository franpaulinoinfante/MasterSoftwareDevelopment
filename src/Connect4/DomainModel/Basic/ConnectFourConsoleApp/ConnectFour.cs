using ConnectFourConsoleApp;
using ConnectFourConsoleApp.ConsoleIOs;
using ConnectFourConsoleApp.Types;

internal class ConnectFour
{
    private readonly Board _board;
    private readonly Player[] _players;
    private readonly Turn _turn;

    public ConnectFour()
    {
        _board = new Board();
        _players = new Player[Turn.Players];
        _turn = new Turn(_players);
        NewGame();
    }
    internal void Start()
    {
        do
        {
            MessageCode.Title.WriteLine();
            _board.Write();
            Play();
        } while (Resume());
    }

    internal void Play()
    {
        do
        {
            _players[(int)_turn.CurrentPlayer.Token].Insert();
            _turn.Next();
            _board.Write();
        } while (!IsFinished());

        if (_board.IsWinner(_turn.LastPlayer.Token))
        {
            _players[(int)_turn.LastPlayer.Token].SingVictory();
        }
        else
        {
            MessageCode.Tie.WriteLine();
        }
    }

    private bool IsFinished()
    {
        return _board.IsWinner(_turn.LastPlayer.Token) || _board.IsTie();
    }

    internal bool Resume()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(MessageCode.Resume.GetMessage());
        if (yesNoDialog.IsAffirmative())
        {
            NewGame();
        }
        return yesNoDialog.IsAffirmative();
    }

    private void NewGame()
    {
        _board.Reset();
        for (int i = 0; i < Turn.Players; i++)
        {
            _players[i] = new Player(_board, Enum.GetValues<Token>()[i]);
        }
        _turn.Reset();
    }
}