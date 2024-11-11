using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ComputerLogic : CommonLogic
    {
        public static List<string> cardsComputer = new List<string>();
        
        public static void Move()
        {
            continueAddCards = true;
            while (continueAddCards)
            {
                int sum = CardsSum(cardsComputer);
                if (sum < MAX_SUM)
                {
                    if (sum <= 16)
                    {
                        isAddCard = true;
                    }
                    else
                    {
                        Random random = new Random();
                        if (random.Next(0, 4) == 3)
                            isAddCard = true;
                        else
                            isAddCard = false;

                        continueAddCards = false;
                    }
                }
                else { break; }
                isAddingCards(isAddCard, ref continueAddCards, cardsComputer, PlayerLogic.cardsPlayer);
            }
        }
    }
}
