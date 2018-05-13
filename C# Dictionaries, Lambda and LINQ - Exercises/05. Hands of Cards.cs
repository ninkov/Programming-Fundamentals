using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class HandsOfCards
    {
        static void Main()
        {
            string inputLine = string.Empty;

            Dictionary<string, int> powers = GetPowers();
            Dictionary<char, int> suits = GetSuits();
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>(); //remebar players 

            //read input
            while ((inputLine = Console.ReadLine())!= "JOKER")
            {
                string[] tokens = inputLine.Split(new[] { ": " }, StringSplitOptions.RemoveEmptyEntries);//split input line
                string playerName = tokens[0];//take players name 
                string[] cards = tokens[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);//take cardc

                if (!players.ContainsKey(playerName))
                {
                    players.Add(playerName, new List<string>());
                }
                players[playerName].AddRange(cards);

            }
            //final action
            foreach (var player in players)
            {
                string name = player.Key;
                string[] cards = player.Value
                                       .Distinct()
                                       .ToArray();

                long cardSum = GetCardSum(cards, powers, suits); 
                Console.WriteLine($"{name}: {cardSum}");
            }
        }
        // get total sum method 
        private static long GetCardSum(string[] cards, Dictionary<string, int> powers, Dictionary<char, int> suits)
        {
            long sum = 0L;

            foreach (var card in cards)
            {
                string power = card[0].ToString();
                char suit = card[card.Length - 1];

				sum += powers[power] * suits[suit];
            }
            return sum;
        }

        //method for get suits
        private static Dictionary<char, int> GetSuits()
        {
            Dictionary<char, int> suits = new Dictionary<char, int>();

            suits.Add('S', 4);
            suits.Add('H', 3);
            suits.Add('D', 2);
            suits.Add('C', 1);

            return suits;
        }


        //methods to take powers of cards
        private static Dictionary<string, int> GetPowers()
        {
            Dictionary<string, int> powers = new Dictionary<string, int>();

            for (int i = 2; i < 11; i++)
            {
                string powerKey = i.ToString();
                int powerValue = i;

                powers.Add(powerKey, powerValue);
            }
            powers.Add("1", 10);
            powers.Add("J", 11);
            powers.Add("Q", 12);
            powers.Add("K", 13);
            powers.Add("A", 14);


            return powers;
        }
    }
}

