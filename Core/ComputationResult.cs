using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ComputationResult
    {
        public int Digit { get; set; }
        public UInt64 TryCount { get; set; }
        public TimeSpan Duration { get; set; }

        public ComputationResult()
        {

        }

        public ComputationResult(int Digit, UInt64 TryCount)
        {
            this.Digit = Digit;
            this.TryCount = TryCount;
        }
    }
}