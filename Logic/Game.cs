using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Game : CommonLogic
    {
        private static int MAX_SUM = 30;
        public static void Run()
        {
            do
            {
                List<string> cardsPlayer = PlayerLogic.cardsPlayer;
                List<string> cardsComputer = ComputerLogic.cardsComputer;
                AddFirstCards(cardsPlayer, cardsComputer);
                AddFirstCards(cardsComputer, cardsPlayer);
                ShowCards(cardsPlayer);
                while (true)
                {
                    bool isAddCard = false;
                    if (CardsSum(cardsPlayer) < MAX_SUM) isAddCard = EnterBoolean("1 - так\n0 - ні\nБажаєте добрати карту?: ");
                    else { Console.WriteLine($"Ви більше не можете брати карти, оскільки їх сума перевищує {MAX_SUM}"); break; }

                    if (isAddCard)
                        AddCard(cardsPlayer);
                    else
                        break;

                    ShowCards(cardsPlayer);
                }

                Clear(cardsPlayer);
                Clear(cardsComputer);
            }
            while (Restart());
            Exit();
        }

        private static bool EnterBoolean(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string str = Console.ReadLine();
                Console.WriteLine();
                try
                {
                    return Convert.ToBoolean(int.Parse(str));
                }
                catch
                {
                    Console.Write("\nСталась помилка, спробуйте ще раз: ");
                }
            }
        }

        private static bool Restart() => EnterBoolean("1 - так\n0 - ні\nБажаєте почати гру знову?: ");

        private static void Exit() 
        {
            Console.WriteLine("Дякую, що грали в мою гру!\nДля зв'язку пишіть в Telergam: @o5tapov");
            Environment.Exit(0); 
        }
    }
}
