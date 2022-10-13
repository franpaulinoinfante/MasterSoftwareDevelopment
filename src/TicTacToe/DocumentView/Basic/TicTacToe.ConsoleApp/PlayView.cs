using TicTacToe.Models;
using TicTacToe.Views;

internal class PlayView : WithGameView
{
    public PlayView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        if (!_game.AreAllTokenObBoard())
        {
            PutToken();
        }
        else
        {
            MoveToken();
        }
    }

    private void PutToken()
    {
        throw new NotImplementedException();
    }

    private void MoveToken()
    {
        throw new NotImplementedException();
    }
}