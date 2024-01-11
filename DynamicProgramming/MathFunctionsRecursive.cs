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
            if (n == 0)
                return 1;
            return n * Factorial(n-1);
        }
    }
}