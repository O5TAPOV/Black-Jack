using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class PlayerLogic : CommonLogic
    {
        public static List<string> cardsPlayer = new List<string>();

        public static void Move()
        {
            while (continueAddCards)
            {
                ShowCards("гравця", cardsPlayer);
                if (CardsSum(cardsPlayer) < MAX_SUM) isAddCard = EnterBoolean("1 - так\n0 - ні\nБажаєте добрати карту?: ");
                else { Console.WriteLine($"Ви більше не можете брати карти, оскільки їх сума перевищує {MAX_SUM}"); break; }
                isAddingCards(isAddCard, ref continueAddCards, cardsPlayer, ComputerLogic.cardsComputer);
            }
        }
    }
}
