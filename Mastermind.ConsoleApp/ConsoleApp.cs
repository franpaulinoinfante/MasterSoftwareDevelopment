using Mastermind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.ConsoleApp
{
    internal class ConsoleApp
    {
        private Game _game;
        private ConsoleView _consoleView;

        public ConsoleApp()
        {
            _game = new Game();
            _consoleView = new ConsoleView(_game);
        }

        internal void Run()
        {
            Console.WriteLine("Initial ");
        }

        private void Play()
        {
            throw new NotImplementedException();
        }
    }
}
