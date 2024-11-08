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
            Game.Run();
        }
    }
}
