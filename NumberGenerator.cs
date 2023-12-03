namespace DiceRollGame
{
    public class NumberGenerator
    {
        public NumberGenerator() { }

        public int Generate(int min, int max)
        {
            return new Random().Next(min, max);

        }
    }
}
