using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    class MixedDeck : Deck
    {
        public MixedDeck()
        {
            Cards = GetCards();
        }

        public override List<Card> GetCards()
        {
            var mixedCards = new List<Card>();

            mixedCards.AddRange(new AnimalDeck().Cards);
            mixedCards.AddRange(new PlayingCardDeck().Cards);

            return mixedCards;
        }
    }
}
