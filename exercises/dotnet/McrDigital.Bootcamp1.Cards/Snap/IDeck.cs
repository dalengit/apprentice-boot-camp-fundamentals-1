using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public interface IDeck
    {
        ICard Deal();
        List<ICard> GetCards();
        void Shuffle();
    }
}