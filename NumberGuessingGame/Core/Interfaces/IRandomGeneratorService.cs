using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Core.Interfaces
{
    public interface IRandomGeneratorService
    {
        /// <summary>
        /// Генерирует случайное числов в диапазоне от <paramref name="MinRangeValue"/> до <paramref name="MaxRangeValue"/>
        /// </summary>
        /// <param name="MinRangeValue"></param>
        /// <param name="MaxRangeValue"></param>
        /// <returns></returns>
        int Generate(int MinRangeValue, int MaxRangeValue);
    }
}
