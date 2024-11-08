using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Logic
{
    public class CommonLogic
    {
        public static List <string> cards = new List<string>();
        public void AddFirstCards(List<string> targetCards = null) 
        {
            targetCards ??= cards;
            targetCards.Add(Cards.GenerateCard());
            targetCards.Add(Cards.GenerateCard()); 
        }
        public void AddCard() 
        {
            string card;
            while (true)
            {
                card = Cards.GenerateCard();
                if (!cards.Contains(card)) { cards.Add(card); break; }
            }
        }

        public static byte cardPrice_From6toK(string card)
        {
            switch (card)
            {
                case "6": return 6;
                case "7": return 7;
                case "8": return 8;
                case "9": return 9;
                case "10": return 10;
                case "J": return 2;
                case "Q": return 3;
                case "K": return 4;
            }
            return 0;
        }

        public static string GetCardNominal(string card) => card.Substring(1);
        public static byte CardsSum()
        {
            List<int> sum = new List<int>();
            List<string> nominalCards = cards.Select(GetCardNominal).ToList();

            //Перенесення "Туза" в кінець списку
            if (nominalCards.Contains("A") && nominalCards.Last() != "A")
            {
                nominalCards.Remove("A");
                nominalCards.Add("A");
            }

            //Підсумовування
            foreach (string c in nominalCards)
            {
                if (c == "A")
                {
                    if (sum.Sum() > 10) sum.Add(1);
                    else sum.Add(11);
                }

                sum.Add(cardPrice_From6toK(c));
            }
            return (byte)sum.Sum();
        }

        public void OutputCards()
        {
            Console.Write("Ваші карти: ");
            foreach (string c in cards) Console.Write($"{c} ");
            Console.WriteLine("\nСума карт: " + CardsSum());
        }
    }
}
