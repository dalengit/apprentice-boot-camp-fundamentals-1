using System.Net.WebSockets;

namespace McrDigital.Bootcamp1.Cards
{
    using System;
    using System.Collections.Generic;

    public class AnimalDeck : Deck
    {
        public AnimalDeck()
        {
            Cards = GetCards();
        }
        public override List<Card> GetCards()
        {
            var cards = new List<Card>();
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                cards.Add(new AnimalCard(animal));
                cards.Add(new AnimalCard(animal));
            }

            return cards;
        }
    }
}