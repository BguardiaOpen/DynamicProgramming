using DynamicProgramming;

Console.WriteLine("With recursion:");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Factorial of {0} is {1}", i, MathFunctionsRecursive.Factorial(i));
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Fibonacci of {0} is {1}", i, MathFunctionsRecursive.Fibonacci(i));
}

Console.WriteLine("With dynamic programming:");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Factorial of {0} is {1}", i, MathFunctionsDP.Factorial(i));
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Fibonacci of {0} is {1}", i, MathFunctionsDP.Fibonacci(i));
}