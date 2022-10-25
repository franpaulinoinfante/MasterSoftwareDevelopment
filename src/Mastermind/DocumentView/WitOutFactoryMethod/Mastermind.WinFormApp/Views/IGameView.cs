using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.WinFormApp.Views;

internal interface IGraphic 
{
    string Title { set; }
    string SecrectCombination { set; }
    string ProposedCombination { get; }


    event EventHandler GetproposedCombinationEvent;

    void GetProposeCombinationsBindingSource(BindingSource bindingSource);
    //void DisplaysBoard();

}
