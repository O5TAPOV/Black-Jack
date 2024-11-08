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
        private static List <string> cards = new List<string>();
        public static void AddCard(List<string> firstCards = null, List<string> secondCards = null) 
        {
            string card;
            firstCards ??= cards;
            while (true)
            {
                card = Cards.GenerateCard();
                if (!firstCards.Contains(card) && (secondCards == null || !secondCards.Contains(card))) { firstCards.Add(card); break; }
            }
        }
        public static void AddFirstCards(List<string> firstCards = null, List<string> secondCards = null) { 
            AddCard(firstCards, secondCards); AddCard(firstCards, secondCards); 
        }

        private static byte cardConvertationFrom6toK(string card)
        {
            return card switch
            {
                "6" => 6,
                "7" => 7,
                "8" => 8,
                "9" => 9,
                "10" => 10,
                "J" => 2,
                "Q" => 3,
                "K" => 4,
                _ => 0
            };
        }
        private static string GetCardNominal(string card) => card.Substring(1);
        public static byte CardsSum(List<string> targetCards = null)
        {
            targetCards ??= cards;
            List<int> sum = new List<int>();
            List<string> nominalCards = targetCards.Select(GetCardNominal).ToList();

            //Перенесення "Туза" в кінець списку
            if (nominalCards.Contains("A") && nominalCards.Last() != "A")
            {
                nominalCards.Remove("A");
                nominalCards.Add("A");
            }

            //Підсумовування
            foreach (string c in nominalCards)
            {
                if (c == "A") sum.Add(sum.Sum() > 10 ? 1 : 11);
                sum.Add(cardConvertationFrom6toK(c));
            }
            return (byte)sum.Sum();
        }

        public static void ShowCards(List<string> targetCards = null)
        {
            Console.Clear();
            targetCards ??= cards;
            Console.Write("Карти: ");
            foreach (string c in targetCards) Console.Write($"{c} ");
            Console.WriteLine($"\nСума карт: {CardsSum(targetCards)}\n");
        }

        public static void Clear(List<string> targetCards = null)
        {
            targetCards ??= cards;
            targetCards.Clear();
        }
    }
}
