using Common;
using Logic;
using ConsoleOutput;
using static Logic.CommonLogic;

namespace Black_Jack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.ConsoleSetting();
            List<string> cardsPlayer = PlayerLogic.cardsPlayer;
            List<string> cardsComputer = ComputerLogic.cardsComputer;
            AddFirstCards(cardsPlayer, cardsComputer);
            AddFirstCards(cardsComputer, cardsPlayer);
            ShowCards(cardsPlayer);
            ShowCards(cardsComputer);
            AddCard(cardsPlayer);
            ShowCards(cardsPlayer);
        }
    }
}
