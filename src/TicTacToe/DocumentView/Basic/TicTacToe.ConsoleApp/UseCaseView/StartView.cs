using TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;
using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView;

internal class StartView
{
    private readonly Game _game;

    public StartView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        new MessageView(MessageType.TITLE).WriteLine();
        new BoardView().Write(_game);
    }
}