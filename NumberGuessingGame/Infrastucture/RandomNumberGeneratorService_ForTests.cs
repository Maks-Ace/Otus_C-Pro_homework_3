using NumberGuessingGame.Core.Interfaces;

namespace NumberGuessingGame.Infrastucture
{
    public class RandomNumberGeneratorService_ForTests : IRandomGeneratorService
    {

        public int Generate(int MinRangeValue, int MaxRangeValue)
        {
            return 5;
        }
    }
}
