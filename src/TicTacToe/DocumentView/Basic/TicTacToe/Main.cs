﻿using TicTacToe.Models;
using TicTacToe.Views;

namespace TicTacToe;

public abstract class Main
{
    private readonly Game _game;
    private readonly View _view;

    public Main()
    {
        _game = new Game();
        _view = CreateView(_game);
    }

    protected abstract View CreateView(Game game);



    protected void Play()
    {
        do
        {
            _view.Start();
            _view.Play();
        } while (_view.Resume());
    }
}
