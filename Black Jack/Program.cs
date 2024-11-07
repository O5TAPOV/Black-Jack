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
            CommonLogic cards = new CommonLogic();
            cards.AddFirstCards();
            cards.OutputCards();
            cards.AddCard();
            cards.OutputCards();
        }
    }
}
