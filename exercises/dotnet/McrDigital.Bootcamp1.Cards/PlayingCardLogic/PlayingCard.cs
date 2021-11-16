namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCard : Card
    {
        public PlayingCard(Suit suit, string faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        }
        public Suit Suit { get; set; }
        public override string ToString()
        {
            return $"{FaceValue} of {Suit}";
        }
    }
}