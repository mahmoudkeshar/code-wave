namespace Day_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Sum of Two Numbers using String Interpolation
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");

            // 2. Operations with Specified Test Data
            int result1 = -1 + 4 * 6;
            int result2 = (35 + 5) % 7;
            int result3 = 14 + -4 * 6 / 11;
            int result4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine($"Result of -1 + 4 * 6: {result1}");
            Console.WriteLine($"Result of (35 + 5) % 7: {result2}");
            Console.WriteLine($"Result of 14 + -4 * 6 / 11: {result3}");
            Console.WriteLine($"Result of 2 + 15 / 6 * 1 - 7 % 2: {result4}");

            // 3. Comparing Results Between Three Integer Values (5 Complex Expressions)
            int a = 10;
            int b = 20;
            int c = 30;

            bool comparison1 = a + b > c;  // a + b > c
            bool comparison2 = a * c == b; // a * c == b
            bool comparison3 = (a + b) % 3 == 0; // (a + b) % 3 == 0
            bool comparison4 = b - a <= c; // b - a <= c
            bool comparison5 = (a * b) > (c - a); // a * b > c - a

            Console.WriteLine($"a + b > c: {comparison1}");
            Console.WriteLine($"a * c == b: {comparison2}");
            Console.WriteLine($"(a + b) % 3 == 0: {comparison3}");
            Console.WriteLine($"b - a <= c: {comparison4}");
            Console.WriteLine($"a * b > c - a: {comparison5}");
        }
    }
}
