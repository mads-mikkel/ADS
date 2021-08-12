using System;

namespace ADS.Generators
{
    public class ArrayGenerator
    {
        public int[] GenerateArray(int n, int maxValue)
        {
            Random numberGenerator = new();
            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = numberGenerator.Next(0, maxValue);
            }
            return array;
        }
    }
}