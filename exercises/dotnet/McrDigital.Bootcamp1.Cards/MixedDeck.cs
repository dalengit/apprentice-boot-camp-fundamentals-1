﻿using System;
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
            var animalDeck = new AnimalDeck().GetCards();
            var playingCardDeck = new PlayingCardDeck().GetCards();

            mixedCards.AddRange(animalDeck);
            mixedCards.AddRange(playingCardDeck);

            return mixedCards;
        }
    }
}
