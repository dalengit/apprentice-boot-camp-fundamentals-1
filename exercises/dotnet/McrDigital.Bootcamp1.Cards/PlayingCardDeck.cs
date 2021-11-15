using System;
using System.Collections.Generic;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCardDeck
    {
        public List<PlayingCard> Cards { get; set; }

        public List<PlayingCard> GetCards()
        {
            var listOfCards = new List<PlayingCard>();

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