using System;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SuperList list = new SuperList { 5.5, 3.1, 9.8, 2.4, 7.0 };

            list.GetMinMax1(out double min, out double max);

            Console.WriteLine($"Min Value: {min}, Max Value: {max}");
        }
    }
}
