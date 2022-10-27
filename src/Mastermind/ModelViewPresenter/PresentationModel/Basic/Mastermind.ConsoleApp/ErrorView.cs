using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;
using Mastermind.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.ConsoleApp
{
    internal class ErrorView : GameViews.ErrorView
    {
        public override void WriteLine(ErrorCode errorCode)
        {
            if (!errorCode.IsNull())
            {
                ConsoleIO.GetInstance().WriteLine(Errors[(int)errorCode]);
            }
        }
    }
}
