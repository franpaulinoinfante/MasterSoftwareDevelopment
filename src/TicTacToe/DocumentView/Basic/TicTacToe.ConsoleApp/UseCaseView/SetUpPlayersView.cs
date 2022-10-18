using TicTacToe.ConsoleApp.ConsolesIOs;
using TicTacToe.ConsoleApp.UseCaseView.AuxiliaryViews;
using TicTacToe.Models;
using TicTacToe.Models.Types;
using TicTacToe.Views;

namespace TicTacToe.ConsoleApp.UseCaseView;

internal class SetUpPlayersView
{
    private readonly Game _game;

    public SetUpPlayersView(Game game)
    {
        _game = game;
    }

    internal void Interact()
    {
        int numPlayers = new BoundedIntDialog(min: 0, SetUp.NUM_PLAYERS)
            .Read(new MessageView(MessageType.NUMBER_PLAYERS).ToString());
        _game.SetUpPlayers(numPlayers);
    }
}