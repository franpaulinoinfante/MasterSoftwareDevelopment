using Mastermind.Models;

namespace Mastermind.ConsoleApp
{
    internal class ConsoleMastermind
    {
        private readonly Game _game;
        private readonly ConsoleView _consoleView;

        public ConsoleMastermind()
        {
            _game = new Game();
            _consoleView = new ConsoleView(_game);
        }

        internal void Execute()
        {
            Play();
        }

        private void Play()
        {
            do
            {
                _consoleView.Start();
                _consoleView.Play();
            } while (_consoleView.Resume());
        }
    }
}
