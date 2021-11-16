using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public interface IDeck
    {
        Card Deal();
        List<Card> GetCards();
        void Shuffle();
    }
}