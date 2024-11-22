using NumberGuessingGame.Core.Interfaces;

namespace NumberGuessingGame.Infrastucture
{
    public class RandomNumberGeneratorService : IRandomGeneratorService
    {

        private readonly Random _random;

        public RandomNumberGeneratorService()
        {
            _random = new Random();
        }


        public int Generate(int MinRangeValue, int MaxRangeValue)
        {
            return _random.Next(MinRangeValue, MaxRangeValue + 1);
        }
    }
}
