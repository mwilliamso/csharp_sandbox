using System;

namespace NumberFrequencyTest.frequencyOO.services
{
    public class NumberFrequencyService
    {
        private NumberFrequencies numberFrequencies;

        public NumberFrequencyService()
        {
        }

        public NumberFrequencies CalculateFrequencies(long value, int numberBase)
        {
            numberFrequencies = new NumberFrequencies(numberBase);

            int[] numberSequence = SplitInputNumberIntoArrayOfNumbers(value);
            for (int i = 0; i < numberSequence.Length; i++)
            {
                IncrementFrequency(numberSequence[i]);
            }

            numberFrequencies.SortByFrequency();

            return numberFrequencies;
        }

        public void PrintOutFrequencies(NumberFrequencies numberFrequencies)
        {
            Console.Write(numberFrequencies.GetAsFormattedString());
        }

        private int[] SplitInputNumberIntoArrayOfNumbers(long value)
        {
            String inputString = Convert.ToString(value);
            char[] charArray = inputString.ToCharArray();
            int[] numberSequence = new int[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                int numberAtIndex = Convert.ToInt32(new String(charArray[i], 1));
                numberSequence[i] = numberAtIndex;
            }
            return numberSequence;
        }

        private void IncrementFrequency(int number)
        {
            foreach (NumberFrequency numberFrequency in numberFrequencies.GetNumberFrequencies())
            {
                if (numberFrequency.GetNumber() == number)
                {
                    numberFrequency.IncrementFrequency();
                }
            }
        }

    }
}
