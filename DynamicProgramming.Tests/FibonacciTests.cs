using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.Tests
{
    public class FibonacciTests
    {
        [Fact]
        public void TestFibonacci2()
        {
            // arrange
            // act
            int result = MathFunctionsRecursive.Fibonacci(2);
            // assert
            Assert.Equal(1, result);
        }
    }
}
