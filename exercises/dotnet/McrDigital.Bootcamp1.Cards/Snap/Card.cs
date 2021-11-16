using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Card
    {
        public string FaceValue { get; set; }

        public bool Snap(Card card)
        {
            return card.FaceValue == FaceValue;
        }
    }
}
