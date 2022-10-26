using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.WinFormApp.Views;

namespace Mastermind.WinFormApp;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new GraphicMastermind().Execute());
    }
}