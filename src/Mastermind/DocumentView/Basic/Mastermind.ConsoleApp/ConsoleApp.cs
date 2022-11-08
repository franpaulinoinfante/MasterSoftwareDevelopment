using Mastermind.Models;

internal class ConsoleApp
{
    private readonly Game _game;
    private readonly GameView _gameView;

    public ConsoleApp()
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
        } while (_gameView.Resume());
    }

    public static void Main(string[] args)
    {
        new ConsoleApp().Play();
    }
}