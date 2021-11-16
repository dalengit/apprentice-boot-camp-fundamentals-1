using System.Net.WebSockets;

namespace McrDigital.Bootcamp1.Cards
{
    using System;
    using System.Collections.Generic;

    public class AnimalDeck : IDeck
    {
        private readonly List<AnimalCard> _cards;

        public AnimalDeck()
        {
            _cards = new List<AnimalCard>();
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                _cards.Add(new AnimalCard(animal));
                _cards.Add(new AnimalCard(animal));
            }
        }

        public ICard Deal()
        {
            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }

        public List<ICard> GetCards()
        {
            var cards = new List<ICard>();
            foreach (Animal animal in Enum.GetValues(typeof(Animal)))
            {
                cards.Add(new AnimalCard(animal));
                cards.Add(new AnimalCard(animal));
            }

            return cards;
        }

        public void Shuffle()
        {
            _cards.KnuthShuffle();
        }
    }
}