using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Deck
    {
        public List<Card> Cards { get; set; }

        public Card Deal()
        {
            var card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
        public void Shuffle()
        {
            Cards.KnuthShuffle();
        }
        public abstract List<Card> GetCards();
    }
}