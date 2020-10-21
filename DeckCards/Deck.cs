using System;
using System.Collections.Generic;
using System.Text;

namespace DeckCards
{
    class Deck
    {
        public List<Card> cards { get; set; }
        public List<Card> pulledCards { get; set; }
        public Deck()
        {
            this.Build();
            pulledCards = new List<Card>();
        }
        public void Build()
        {
            cards = new List<Card>();
            foreach (var suite in new[] { "Clubs", "Diamonds", "Spades", "Hearts" })
            {
                for (var rank = 1; rank <= 13; rank++)
                {
                    cards.Add(new Card(rank, suite));
                }
            }
            Console.WriteLine("Deck of Card Build! Total Cards: "+ cards.Count);
        }

        public void PullRandomCard()
        {
            if (cards.Count != 0)
            {
                var random = new Random();
                int randomCardIndex = random.Next(cards.Count);
                Card randomCard = cards[randomCardIndex];
                cards.RemoveAt(randomCardIndex);
                pulledCards.Add(randomCard);
                Console.WriteLine("You Pulled Card " + randomCard.Rank + " of " + randomCard.Suite);
                Console.WriteLine("Cards left in Deck: " + cards.Count);
                Console.WriteLine("Cards Already Taken Out: " + pulledCards.Count);

            }
            
        }

        public void FinalOut()
        {
            Console.WriteLine(" ");
            if(cards.Count == 0)
            {
                Console.WriteLine("No Cards Left in Deck!");
            }
            
            Console.WriteLine("Total Cards Remaining in Deck: " + cards.Count);
            Console.WriteLine("Total Cards Taken Out From Deck: " + pulledCards.Count);
        }
    }
}
