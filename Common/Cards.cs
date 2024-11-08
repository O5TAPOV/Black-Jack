using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Cards
    {
        private static List<string> cardSuit = new List<string> {"♠", "♥", "♦", "♣"}; //Масті
        private static List<string> cardDenomination = new List<string> {"6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        private static Random rand = new Random();
        private static string RandomSuit() => cardSuit[rand.Next(cardSuit.Count)]; //Рандомна масть
        private static string RandomDenomination() => cardDenomination[rand.Next(cardDenomination.Count)]; //Рандомний номінал карти

        public static string GenerateCard() => RandomSuit() + RandomDenomination();
        
    }
}
