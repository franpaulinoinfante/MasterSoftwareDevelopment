using TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;
using TicTacToe.ConsoleApp.UseCaseView.PlayerViews;
using TicTacToe.Models;

namespace TicTacToe.ConsoleApp.UseCaseView;

internal class PlayView
{
    private readonly Game _game;

    public PlayView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        do
        {
            new PlayerViewProtoype().CreateView(_game.CurrentPlayerType).Interact(_game);
            new BoardView().Write(_game);
            _game.Next();
        } while (!_game.IsTicTacToe());
    }
}