﻿using Mastermind.ConsoleApp;
using Mastermind.Models;

internal class GameView : WithGameView
{
    private readonly StartView _startView;
    private readonly PlayView _playView;
    private readonly ResumeView _resumeView;

    public GameView(Game game) : base(game)
    {
        _startView = new StartView(game);
        _playView = new PlayView(game);
        _resumeView = new ResumeView(game);
    }

    internal void Start()
    {
        _startView.Interact();
    }

    internal void Play()
    {
        _playView.Interact();
    }

    internal bool Resume()
    {
        return _resumeView.Interact();
    }
}