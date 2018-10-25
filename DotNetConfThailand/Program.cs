using static System.Console;

namespace DotNetConfThailand
{
    public static class Program
    {
        public static int RefDemo(int x, int y)
        {
            x++; y--;
            return x;
        }

        public static void Main(string[] args)
        {
            int a = 1, b = 10;
            int c = RefDemo(a, b);
            c += 100;

            WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
