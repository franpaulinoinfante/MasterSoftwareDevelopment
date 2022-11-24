using ConnectFour.GameViews;
using ConnectFour.Models;

internal class PlayView : WithGameView
{
    public PlayView(Game game) : base(game)
    {
    }

    internal void Interact()
    {
        do
        {
            ConsoleIO.Instance.WriteLine($"{Message.TurnOf.GetToString()} {_game.GetCurrentTurn()}");
            PlayerViewCreator.Instance.Create(_game).Interact();
            _game.Next();
            new BoardView().Write(_game);
        } while (!_game.IsFinished());

        new ResultView().WriteLine(_game.IsWinner(), _game.GetWinner().ToString());
    }
}