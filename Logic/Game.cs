using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Game : CommonLogic
    {
        
        public static void Run()
        {
            List<string> cardsPlayer = PlayerLogic.cardsPlayer;
            List<string> cardsComputer = ComputerLogic.cardsComputer;
            
            do
            {
                AddFirstCards(cardsPlayer, cardsComputer);
                AddFirstCards(cardsComputer, cardsPlayer);

                PlayerLogic.Move();
                ComputerLogic.Move();
                
                ShowCards("гравця", cardsPlayer);
                ShowCards("комп'ютера", cardsComputer, true);
                Console.WriteLine($"Winner: {Results(cardsPlayer, cardsComputer)}");
                Clear(cardsPlayer);
                Clear(cardsComputer);
                continueAddCards = true;
            }
            while (Restart());
            Exit();
        }

        private static bool Restart() => EnterBoolean("\n1 - так\n0 - ні\nБажаєте почати гру знову?: ", true);

        private static void Exit() 
        {
            Console.WriteLine("Дякую, що грали в мою гру!\nДля зв'язку пишіть в Telergam: @o5tapov");
            Environment.Exit(0); 
        }
    }
}
