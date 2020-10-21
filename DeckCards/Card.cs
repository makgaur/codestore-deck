using System;
using System.Collections.Generic;
using System.Text;

namespace DeckCards
{
    class Card
    {
        public Card(int rank, string suite)
        {
            this.Rank = rank;
            this.Suite = suite;
        }

        public int Rank { get; set; }
        public string Suite { get; set; }
    }
}
