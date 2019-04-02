using System;
using System.Text;

namespace NumberFrequencyTest.frequencyOO
{
    public class NumberFrequencies
    {

        private NumberFrequency[] numberFrequencies;

        public NumberFrequencies(int numberBase)
        {
            numberFrequencies = new NumberFrequency[numberBase];
            for(int number = 0; number < numberBase; number++) 
            {
                numberFrequencies[number] = new NumberFrequency(number);
            }
        }

        public NumberFrequency[] GetNumberFrequencies()
        {
            return numberFrequencies;
        }

        public void SortByFrequency()
        {
            // todo sort by frequency
            Array.Sort<NumberFrequency>(numberFrequencies, new Comparison<NumberFrequency>(
                  (i1, i2) => i2.CompareTo(i1)));
        }

        public String GetAsFormattedString() {
            StringBuilder sb = new StringBuilder();
            bool first = true;
            sb.Append("[");
            foreach (NumberFrequency numberFrequency in numberFrequencies)
            {
                if(!first)
                {
                    sb.Append(", ");
                }
                sb.Append(numberFrequency.GetFormattedString());
                first = false;
            }
            sb.Append("]");

            return sb.ToString();
        }

    }
}
