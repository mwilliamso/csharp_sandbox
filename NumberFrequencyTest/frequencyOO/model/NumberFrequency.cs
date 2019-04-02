using System;
using System.Text;

namespace NumberFrequencyTest.frequencyOO
{
    public class NumberFrequency : IComparable
    {

        private int number;
        private int frequency;

        public NumberFrequency(int number)
        {
            this.number = number;
            this.frequency = 0;
        }

        public int GetNumber()
        {
            return number;
        }

        public void IncrementFrequency()
        {
            frequency++;
        }

        public int GetFrequency()
        {
            return frequency;
        }

        public int CompareTo(Object that)
        {

            if (that == null) return 1;

            NumberFrequency otherNumberFrequency = that as NumberFrequency;
            if (otherNumberFrequency != null)
                return this.frequency.CompareTo(otherNumberFrequency.frequency);
            else
                throw new ArgumentException("Object is not a NumberFrequency");
        }

        public String GetFormattedString()
        {
            return new StringBuilder().Append(number).Append(" => ").Append(frequency).ToString();
        }
    }
}
