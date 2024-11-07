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
        private static Dictionary<string, byte[]> cardDenomination = new Dictionary<string, byte[]> //Номінал та вартість карти
        {
            {"6", new byte[] {6}}, {"7", new byte[] {7}}, {"8", new byte[] {8}}, {"9", new byte[] {9}}, {"10", new byte[] {10}},
            {"J", new byte[] {2}}, {"Q", new byte[] {3}}, {"K", new byte[] {4}}, {"A", new byte[] {1, 11} }
        };

        private static Random rand = new Random();
        private static string RandomSuit() => cardSuit[rand.Next(cardSuit.Count)]; //Рандомна масть
        private static string RandomDenomination() => cardDenomination.Keys.ElementAt(rand.Next(cardDenomination.Keys.ToList().Count)); //Рандомний номінал карти

        public static string GenerateCard() => RandomSuit() + RandomDenomination();
        
    }
}
