namespace WEEK_2___CLASS_EXERCISE
{
    internal class DelegateCalculatorExample
    {
        static void Main(string[] args)
        {
            AddNumbers((a, b) => a + b);
        }
        static void AddNumbers(Func<int, int, double> sum)
        {
            int x = 6;
            int y = 7;
            double result = sum(x, y);

            Console.WriteLine("Result of addition" + result);
        }

    }
}
