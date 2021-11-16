using System;
using System.Collections.Generic;

namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCardDeck : IDeck
    {
        public PlayingCardDeck()
        {
            Cards = GetCards();
        }
        public List<Card> Cards { get; set; }

        public List<Card> GetCards()
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
    }
}