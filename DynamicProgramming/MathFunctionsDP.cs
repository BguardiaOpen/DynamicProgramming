namespace DynamicProgramming
{
    public class MathFunctionsDP
    {
        static Dictionary<int,int> FibonacciMemory = new();
        static Dictionary<int, int> FactorialMemory = new();

        public static int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;

            if (FibonacciMemory.TryGetValue(n, out int result))
            {
                return result;
            }
            int newResult = Fibonacci(n - 1) + Fibonacci(n - 2);
            FibonacciMemory.Add(n, newResult);
            return newResult;
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            if (FactorialMemory.TryGetValue(n, out int result))
            {
                return result;
            }
            int newFactorial = n * Factorial(n - 1);
            FactorialMemory.Add(n, newFactorial);
            return newFactorial;
        }
    }
}
