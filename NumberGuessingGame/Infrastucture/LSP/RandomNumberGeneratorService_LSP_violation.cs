using System;

namespace NumberGuessingGame.Infrastucture
{
    internal class RandomNumberGeneratorService_LSP_Violation : RandomNumberGeneratorService_Base
    {
        Random _random;
        int _randomValue;

        public RandomNumberGeneratorService_LSP_Violation(int minRangeValue, int MaxRangeValue)
        {
            _random = new Random();

            _randomValue = _random.Next(minRangeValue, MaxRangeValue);
        }


        public int Generate(int MinRangeValue, int MaxRangeValue)
        {
            throw new NotImplementedException();

        }

    }
}
