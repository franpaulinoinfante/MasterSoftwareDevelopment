using Mastermind.WindFormsApp.Presenters;
using Mastermind.WindFormsApp.Views;

namespace Mastermind.WindFormsApp;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        IWindFormView windFormView = new Form1();
        new WindFormViewPresenter(windFormView);
        Application.Run((Form)windFormView);
    }
}