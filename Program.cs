using System;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random globalRan = new Random();
            Console.WriteLine(randomInt(6,6, globalRan));
            Console.WriteLine(randomDouble(8.758, 8.758, globalRan));
            Console.WriteLine(randomRange(2, 6, globalRan));
            Console.WriteLine(randomRange(4.56, 6.56, globalRan));
            Console.WriteLine(generateList(7, 7, 7, globalRan)[4]);
            Console.WriteLine(generateList(7.77, 7.77, 7, globalRan)[6]);

        }
        static int randomInt(int seed, int seed2, Random ran)
        {
            return ran.Next(seed, seed2);
        }
        static double randomDouble(double seed, double seed2, Random ran)
        {
            return ran.NextDouble() * (seed - seed2) + seed;
        }
        static int randomRange(int low, int max, Random ran)
        {
            return ran.Next(low, max);
        }
        static double randomRange(double low, double max, Random ran)
        {
            return ran.NextDouble() * (max - low) + low;
        }
        static int[] generateList(int seed, int seed2, int size, Random ran)
        {
            int[] arr = new int[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = ran.Next(seed, seed2);
            }
            return arr;
        }
        static double[] generateList(double seed, double seed2, int size, Random ran)
        {
            double[] arr = new double[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = randomDouble(seed, seed2, ran);
            }
            return arr;
        }
    }
}
