using Mastermind.ConsoleApp.ConsoleIOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.ConsoleApp.UseCasesViews.ViewModels
{
    internal enum Message
    {   Title,
        Attempts,
        SecrectCombination,
        ProposedCombination,
        Results,
        Winner,
        Lost,
        Resume
    }

   internal static class MessageExtension
    {
        private static string[] Messages =
        {
            "----- MASTERMIND -----",
            "#attempts attempt(s): ",
            "****",
            "Propose a combination: ",
            " --> #blacks blacks and #whites whites",
            "You've won!!! ;-)",
            "You've lost!!! :-(",
            "Do you want to continue"
        };

        internal static void WriteLine(this Message message)
        {
            ConsoleIO.GetInstance().WriteLine(Messages[(int)message]);
        }

        internal static void WriteLine(this Message message, int attempts)
        {
            ConsoleIO.GetInstance().WriteLine(Messages[(int)message].Replace("#attempts", $"{attempts}"));
        }

        internal static void WriteLine(this Message message, int blacks, int whites)
        {
            ConsoleIO.GetInstance().WriteLine(Messages[(int)message]
                .Replace("#blakcs", $"{blacks}")
                .Replace("#whites",$"{whites}"));
        }

        internal static string ToString(this Message message, int value)
        {
            return Messages[(int)message].Replace("#replace", $"{value}");
        }
    }
}
