namespace Mundane.TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = Sum(a, b);
            Console.WriteLine(c);
        }

        /// <summary>
        ///     Returns sum of <paramref name="x"/> and <paramref name="y"/>.
        /// </summary>
        /// <param name="x">First integer</param>
        /// <param name="y">Second integer</param>
        /// <returns>Sum of integers</returns>
        static int Sum(int x, int y)
        {
            return x+y;
        }
    }
}