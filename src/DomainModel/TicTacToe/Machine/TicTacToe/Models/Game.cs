using TicTacToe.ConsolesIO;

namespace TicTacToe.Models;

internal class Game
{
    private readonly Board _board;
    private readonly Turn _turn;
    private readonly Player[] _players;

    public Game()
    {
        _board = new Board();
        _players = new Player[Turn.NUM_PLAYERS];
        _turn = new Turn(_players, _board);
    }

    internal void Start()
    {
        do
        {
            new Message(MessageType.TITLE).WriteLine();
            SetUpPlayers();
            _board.Write();
            Play();
        } while (Resume());
    }

    private void SetUpPlayers()
    {
        int values = ConsoleIO.GetInstance().ReadInt(new Message(MessageType.NUMBER_PLAYERS).ToString());
        _turn.SetUpPlayers(values, _board);
    }

    private void Play()
    {
        bool isTicTacToe;
        do
        {
            _players[_turn.Current].Play();
            _board.Write();
            isTicTacToe = _board.IsTicTacToe(_players[_turn.Current].Token);
            if (!isTicTacToe)
            {
                _turn.Next();
            }
        } while (!isTicTacToe);
        _players[_turn.Current].SingVictory();
    }

    private bool Resume()
    {
        YesNoDialog yesNoDialog = new YesNoDialog();
        yesNoDialog.Read(new Message(MessageType.RESUME).ToString());
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
}
