using Mastermind.ConsoleApp.ConsoleIOs;
using Mastermind.GameViews;
using Mastermind.Models;
using Mastermind.Types;

namespace Mastermind.ConsoleApp.UseCases
{
    internal class ProposedCombinationView
    {
        internal ColorCode[] Read(Game game)
        {
            ColorCode[] colorCodes;
            ErrorCode errorCode;
            do
            {
                string characters = ConsoleIO.GetInstance().ReadString(Message.ProposedCombination.GetString());
                colorCodes = GetColorCodes(characters);
                errorCode = game.GetErrorCodeToProposedCombination(colorCodes);
                new ErrorView().WriteLine(errorCode);
            } while (!errorCode.IsNull());
            return colorCodes;
        }

        private ColorCode[] GetColorCodes(string characters)
        {
            ColorCode[] colorCodes = new ColorCode[characters.Length];
            for (int i = 0; i < characters.Length; i++)
            {
                colorCodes[i] = GetColorCode(characters.ToLower()[i]);
            }
            return colorCodes;
        }

        private ColorCode GetColorCode(char character)
        {
            ColorCode[] colorCodes = Enum.GetValues<ColorCode>();
            int i = 0;
            while ((i < colorCodes.Length - 1) && (colorCodes[i].GetInitial() != character))
            {
                i++;
            }
            return colorCodes[i];
        }

        internal void Write(ColorCode[] colorCodes)
        {
            for (int i = 0; i < colorCodes.Length; i++)
            {
                Console.Write(colorCodes[i].GetInitial());
            }
        }
    }
}