using System;

namespace DeckCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.cards.Shuffle();

            Console.WriteLine(" ");
            Console.WriteLine("Pull Random Card (Y/N) ?");
            while ((Console.ReadLine().ToUpper() == "Y"))
            {
                deck.PullRandomCard();
                if (deck.cards.Count == 0)
                {
                    break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Pull Random Card (Y/N) ?");
            }

            deck.FinalOut();
        }
    }
}
