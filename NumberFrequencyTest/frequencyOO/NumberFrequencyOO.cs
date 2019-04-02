using NumberFrequencyTest.frequencyOO;
using NumberFrequencyTest.frequencyOO.services;

// We need to create a simple routine that calculates the frequency of the digits
// in an 8 byte number, the result needs to be sorted by the frequency.
// For example: Long.MAX_VALUE = 9,223,372,036,854,775,807
//The frequency is:
//[7 => 4, 2 => 3, 3 => 3, 0 => 2, 5 => 2, 8 => 2, 4 => 1, 6 => 1, 9 => 1, 1 =>0]
//This exercise should be done in a IDE and should take less than 30 mins.

namespace NumberFrequencyTest
{
    public class NumberFrequencyOO
    {

        private const int INDEX_FOR_BASE10_ARRAY = 9;

        NumberFrequencyService numberFrequencyService = new NumberFrequencyService();

        public NumberFrequencyOO()
        {
        }

        public void findFrequencies(long value) {

            NumberFrequencies numberFrequencies = numberFrequencyService.CalculateFrequencies(value, INDEX_FOR_BASE10_ARRAY);

            numberFrequencyService.PrintOutFrequencies(numberFrequencies);
        }
    }
}