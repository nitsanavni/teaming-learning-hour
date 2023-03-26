namespace CalcStats
{
    public class CalcStats
    {
        public int MinimumValue { get; private set; }

        public void CalculateStats(int[] numbers)
        {
            MinimumValue = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (MinimumValue < numbers[i])
                {
                    MinimumValue = numbers[i];
                }
            }
        }

    }
}

