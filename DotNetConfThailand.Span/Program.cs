using System;
using static System.Console;

namespace DotNetConfThailand.SpanDemo
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
                array[i] = i;

            foreach (var v in array)
                WriteLine(v);
        }
    }
}
