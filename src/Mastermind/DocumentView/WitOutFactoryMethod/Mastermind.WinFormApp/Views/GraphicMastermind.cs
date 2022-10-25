using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.WinFormApp.Presenter;
using Mastermind.WinFormApp.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.WinFormApp.Views
{
    internal class GraphicMastermind
    {
        private Game _game;
        private GameView _gameView;
        private IGraphic _iGameView;

        public GraphicMastermind()
        {
            _game = new Game();
            _iGameView = new WinFormView();
            _gameView = new GraphicsPresenter(_iGameView, _game);
        }

        internal Form Execute()
        {
            return (Form)_iGameView;
        }
    }
}
