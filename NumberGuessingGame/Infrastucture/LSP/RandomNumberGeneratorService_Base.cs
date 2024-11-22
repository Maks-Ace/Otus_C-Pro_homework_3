using NumberGuessingGame.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Infrastucture
{
    internal class RandomNumberGeneratorService_Base : IRandomGeneratorService
    {

        private readonly Random _random;

        public RandomNumberGeneratorService_Base()
        {
            _random = new Random();
        }


        public int Generate(int MinRangeValue, int MaxRangeValue)
        {
            return _random.Next(MinRangeValue, MaxRangeValue + 1);
        }
    }
}
