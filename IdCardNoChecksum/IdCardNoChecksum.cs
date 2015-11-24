using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IdCardNoChecksum
{
    public class IdCardNoChecksum
    {
        public string Compute(string input)
        {
            if (input.Length != 12)
            {
                throw new ArgumentException("Input Length should be 12.");
            }

            int sum = SummarizeCheckSum(input);
            return CalculateResult(sum);
        }

        private int SummarizeCheckSum(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string digit = input.Substring(i, 1);
                sum += IdCardNoDigit.Calculate(Convert.ToInt32(digit), i + 1);
            }
            return sum;
        }

        private string CalculateResult(int sum)
        {
            int result = sum % 11;
            if (result <= 1)
            {
                return (1 - result).ToString();
            }
            return (11 - result).ToString();
        }
    }
}
