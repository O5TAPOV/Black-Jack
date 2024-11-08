using Common;
using Logic;
using ConsoleOutput;

namespace Black_Jack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings.ConsoleSetting();
            PlayerLogic cardsPlayer = new PlayerLogic();
            cardsPlayer.AddFirstCards();
            cardsPlayer.ShowCards();
            cardsPlayer.AddCard();
            cardsPlayer.ShowCards();
        }
    }
}
