using System;
using System.Collections.Generic;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCardDeck : Deck
    {
        public PlayingCardDeck()
        {
            Cards = GetCards();
        }

        public override List<Card> GetCards()
        {
            var listOfCards = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                listOfCards.Add(new PlayingCard(suit, "ace"));

                for (var faceValue = 2; faceValue <= 10; faceValue++)
                {
                    listOfCards.Add(new PlayingCard(suit, faceValue.ToString()));
                }

                foreach (FaceCard faceCard in Enum.GetValues(typeof(FaceCard)))
                {
                    listOfCards.Add(new PlayingCard(suit, faceCard.ToString()));
                }
            }

            return listOfCards;
        }
    }
}