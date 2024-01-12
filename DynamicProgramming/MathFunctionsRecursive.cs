namespace DynamicProgramming
{
    public class MathFunctionsRecursive
    {
        public static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int Factorial(int n)
        {
            if (n <= 0)
                return 1;
            return n * Factorial(n-1);
        }

        public static int Sum(int start, int end)
        {
            if (end == int.MaxValue) throw new Exception("Value too large");
            int result = 0;
            for (int i = start; i <= end; i++)
                result += i;
            return result;
        }
    }
}