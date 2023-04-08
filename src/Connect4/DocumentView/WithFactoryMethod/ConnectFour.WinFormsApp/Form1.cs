using ConnectFour.Models;

namespace ConnectFour.WinFormsApp;

public partial class Dashboard : Form
{


    public Dashboard(Game game)
    {
        InitializeComponent();
    }

    private void btnClickMe_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hello World");
    }
}
