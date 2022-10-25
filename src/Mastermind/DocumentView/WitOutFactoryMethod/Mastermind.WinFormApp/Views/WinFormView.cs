using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind.WinFormApp.Views;

public partial class WinFormView : Form, IGraphic
{
    private string _proposedCombination;
    private string _title;
    private string _secrectCombination;

    public WinFormView()
    {
        InitializeComponent();
        AsosociateAndRaiseViewEvents();
    }

    public string Title { set => lblTitle.Text = value; }

    public string SecrectCombination { set => lblSecrectCombination.Text = value; }

    public string ProposedCombination { get => txtProposedCombination.Text; }

    private void AsosociateAndRaiseViewEvents()
    {
        btnAddProposedCombination.Click += delegate { GetproposedCombinationEvent?.Invoke(this, EventArgs.Empty); };
    }

    public event EventHandler GetproposedCombinationEvent;

    public void GetProposeCombinationsBindingSource(BindingSource bindingSource)
    {
        listResults.DataSource = bindingSource;
    }

    public void DisplaysBoard()
    {
        throw new NotImplementedException();
    }
}
