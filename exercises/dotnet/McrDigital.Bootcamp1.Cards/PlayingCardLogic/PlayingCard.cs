namespace McrDigital.Bootcamp1.Cards
{
    public class PlayingCard : ICard
    {
        public PlayingCard(Suit suit, string faceValue)
        {
            Suit = suit;
            FaceValue = faceValue;
        }
        public Suit Suit { get; set; }
        public string FaceValue { get; set; }
        public override string ToString()
        {
            return $"{FaceValue} of {Suit}";
        }

        public bool Snap(ICard card)
        {
            var playingCard = (PlayingCard)card;

            return playingCard.FaceValue == FaceValue;
        }
    }
}