namespace ADS.SimpleAlgorithms
{
    public class MeasurementAlgorithm
    {
        public int SumOfElements(int[] array)
        {
            int total = 0;
            for(int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            return total;
        }
    }
}