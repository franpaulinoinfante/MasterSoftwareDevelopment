using ConnectFour.ConsoleApp.Views;
using ConnectFour.Models;

internal class Connect4
{
    private readonly Game _game;
    private readonly GameView _gameView;

    public Connect4()
    {
        _game = new Game();
        _gameView = new GameView(_game);
    }

    internal void Play()
    {
        do
        {
            _gameView.Start();
            _gameView.Play();
        } while (_gameView.IsResume());
    }
}