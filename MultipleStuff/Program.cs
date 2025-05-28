using System;
using static MultipleStuff.SuperList;

namespace MultipleStuff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SuperList list = new SuperList { 5.5, 3.1, 9.8, 2.4, 7.0 };

            //list.GetMinMax1(out double min, out double max);
            MinMaxResult result = list.GetMinMax2();

            //Console.WriteLine($"Min Value: {min}, Max Value: {max}");
            Console.WriteLine($"Min Value: {result.Min}, Max Value: {result.Max}");
        }
    }
}
