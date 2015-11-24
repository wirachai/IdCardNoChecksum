using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdCardNoChecksum
{
    public class IdCardNoDigit
    {
        private const int Priority = 14;
        public static int Calculate(int digit, int sequence)
        {
            int multiplier = Priority - sequence;
            return digit * multiplier;
        }
    }
}
