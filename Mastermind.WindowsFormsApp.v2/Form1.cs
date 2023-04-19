using Mastermind.Controllers;
using Mastermind.GameViews;

namespace Mastermind.WindowsFormsApp.v2;

public partial class Form1 : Form, IGameVIew
{
    public Form1()
    {
        InitializeComponent();
    }


    public void Visit(StartController startController)
    {
        MessageBox.Show(MessageCode.Title.GetMessage());
        startController.NextState();
    }

    public void Visit(PlayController playController)
    {
        playController.NextState();
    }

    public bool Visit(ResumeController resumeController)
    {
        resumeController.NextState();
        return false;
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}
