using System;
using System.Collections.Generic;
namespace T22_Cards
{


    public class Card
    {
        public enum Suites
        {
            Hearts = 0,
            Diamonds,
            Clubs,
            Spades
        }

        public int Value
        {
            get;
            set;
        }

        public Suites Suite
        {
            get;
            set;
        }

        public string NamedValue
        {
            get
            {
                string name = string.Empty;
                switch (Value)
                {
                    case (14):
                        name = "Ace";
                        break;
                    case (13):
                        name = "King";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (11):
                        name = "Jack";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }

                return name;
            }
        }

        public string Name
        {
            get
            {
                return NamedValue + "-" + Suite.ToString();
            }
        }

        public Card(int Value, Suites Suite)
        {
            this.Value = Value;
            this.Suite = Suite;
        }
    }

    public class Deck
    {
        public List<Card> Cards = new List<Card>();
        public void FillDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
                int val = i % 13 + 2;
                Cards.Add(new Card(val, suite));
            }
        }

        public void PrintDeck()
        {
            foreach (Card card in this.Cards)
            {
                Console.WriteLine(card.Name);
            }
        }

    }
    public static class Program
    {
        public static void Main()
        {
            Deck deck = new Deck();
            deck.FillDeck();
            var cards = deck.Cards;
            cards.Shuffle();
            Console.WriteLine($"There are: {cards.Count} cards, beatifully suffled in the deck");
            deck.PrintDeck();
        }

        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}