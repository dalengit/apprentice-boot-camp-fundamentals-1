namespace McrDigital.Bootcamp1.Cards
{
    public class AnimalCard : Card
    {
        public AnimalCard(Animal animal)
        {
            FaceValue = animal.ToString();
        }
        public override string ToString()
        {
            return FaceValue;
        }
    }
}