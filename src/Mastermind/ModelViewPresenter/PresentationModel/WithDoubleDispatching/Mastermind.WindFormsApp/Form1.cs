using Mastermind.Controllers;
using Mastermind.GameViews;
using Mastermind.WindFormsApp.Views;

namespace Mastermind.WindFormsApp;

public partial class Form1 : Form, IWindFormView
{
    public Form1()
    {
        InitializeComponent();


    }

    public string Title { get; set; }

    public event EventHandler StartEvent;

    public void Visit(StartController startController)
    {
        label1.Text = Title;
        tableLayoutPanel1.Visible = true;
    }

    public void Visit(PlayController playController)
    {
        throw new NotImplementedException();
    }

    public bool Visit(ResumeController resumeController)
    {
        throw new NotImplementedException();
    }
}
