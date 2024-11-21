using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame.Core.Interfaces
{
    public interface IGameSettings
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public int MaxNubmerOfAttempts { get; set; }
    }
}
