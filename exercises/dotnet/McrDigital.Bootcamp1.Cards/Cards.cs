using System.Security.Cryptography.X509Certificates;

namespace McrDigital.Bootcamp1.Cards
{
    using System;

    public class Cards
    {
        static void Main(string[] args)
        {
            var encapsulation = new PlayingCardDeck();
            var deckInOrder = encapsulation.GetCards();
            foreach (var card in deckInOrder)
            {
                Console.WriteLine(card);
            }
        }
    }
}